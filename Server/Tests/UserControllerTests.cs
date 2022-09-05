using System.Text;
using System;
using AutoMapper;

namespace UserControllerTests
{
    public class UserControllerTests : IAsyncLifetime
    {
        private readonly Mock<IUserService> _userServiceMock = new();
        private readonly IMapper _mapper = (new MapperConfiguration(cfg =>
        {
            cfg.AddProfile(new AutoMapperConfig());
        })).CreateMapper();

        private HttpClient _httpClient = null!;

        private User testUser = new User() { Id = "1", Email = "test@email.com", UserName = "test" };

        public async Task InitializeAsync()
        {
            var hostBuilder = Program.CreateHostBuilder(new string[0])
            .ConfigureWebHost(webBuilder =>
            {
                webBuilder
                    .ConfigureServices(services =>
                    {
                        services.AddSingleton<IServer>(serviceProvider => new TestServer(serviceProvider));
                        services.AddSingleton(_userServiceMock.Object);
                    });
            });

            var host = await hostBuilder.StartAsync();
            _httpClient = host.GetTestClient();
        }

        public Task DisposeAsync()
        {
            return Task.CompletedTask;
        }

        [Fact]
        public async Task GetUsers_CorrectResponce()
        {

            _userServiceMock.Setup(userService => userService.GetUsers())
                .ReturnsAsync(Result<IEnumerable<UserResponse>>.GetSuccess(new List<UserResponse>() { _mapper.Map<User, UserResponse>(testUser) }));

            var response = await _httpClient.GetAsync($"api/user/getUsers");
            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            var returnedJson = await response.Content.ReadAsStringAsync();
            var returnedUsers = JsonConvert.DeserializeObject<IEnumerable<UserResponse>>(returnedJson);
            Assert.NotNull(returnedUsers);
            Assert.Single(returnedUsers);
        }

        [Fact]
        private async Task GetUsers_ErrorResponce()
        {
            _userServiceMock.Setup(userService => userService.GetUsers())
                .ReturnsAsync(Result<IEnumerable<UserResponse>>.GetError(StatusCodes.Status500InternalServerError, "Users do not exist"));

            var response = await _httpClient.GetAsync($"api/user/getUsers");
            ErrorResponceWithMessageExpected(response, HttpStatusCode.InternalServerError, "Users do not exist");
        }

        [Fact]
        public async Task GetUserByUserName_CorrectResponce()
        {

            _userServiceMock.Setup(userService => userService.GetUserByUsername(testUser.UserName))
                .ReturnsAsync(Result<UserResponse>.GetSuccess(_mapper.Map<User, UserResponse>(testUser)));

            var response = await _httpClient.GetAsync($"api/user/GetUserByUsername?username=test1");
            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            var returnedJson = await response.Content.ReadAsStringAsync();
            var returnedUser = JsonConvert.DeserializeObject<UserResponse>(returnedJson);
            Assert.NotNull(returnedUser);
            Assert.Equal("test1",  returnedUser.Login);
        }

        [Fact]
        private async Task GetUserByUserName_ErrorResponce()
        {
            _userServiceMock.Setup(userService => userService.GetUsers())
                .ReturnsAsync(Result<IEnumerable<UserResponse>>.GetError(StatusCodes.Status500InternalServerError, "Such user does not exist"));

            var response = await _httpClient.GetAsync($"api/user/getUsers");
            ErrorResponceWithMessageExpected(response, HttpStatusCode.InternalServerError, "Such user does not exist");
        }

        [Fact]
        public async Task GetUserByUserName_Responce_FoundUsers()
        {

            _userServiceMock.Setup(userService => userService.GetUsersBySring(testUser.UserName))
                .ReturnsAsync(Result<IEnumerable<UserResponse>>.GetSuccess(new List<UserResponse>() { _mapper.Map<User, UserResponse>(testUser) }));

            var response = await _httpClient.GetAsync($"api/user/getUsersByString?username=test");
            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            var returnedJson = await response.Content.ReadAsStringAsync();
            var returnedUsers = JsonConvert.DeserializeObject<IEnumerable<UserResponse>>(returnedJson);
            Assert.NotNull(returnedUsers);
            Assert.Single(returnedUsers);
        }

        [Fact]
        public async Task GetUserByUserName_Responce_FoundNoUsers()
        {

            _userServiceMock.Setup(userService => userService.GetUsersBySring("test"))
                .ReturnsAsync(Result<IEnumerable<UserResponse>>.GetSuccess(Enumerable.Empty<UserResponse>()));

            var response = await _httpClient.GetAsync($"api/user/getUsersByString?username=test");
            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            var returnedJson = await response.Content.ReadAsStringAsync();
            var returnedUsers = JsonConvert.DeserializeObject<IEnumerable<UserResponse>>(returnedJson);
            Assert.NotNull(returnedUsers);
            Assert.Empty(returnedUsers);
        }

        [Fact]
        public async Task GetEventParticipants_FoundUsers()
        {
            string[] ids = new string[] { testUser.Id };
            _userServiceMock.Setup(userService => userService.GetUsersEventsParticipants(ids))
                .ReturnsAsync(Result<IEnumerable<UserParticipantsResponce>>.GetSuccess(new List<UserParticipantsResponce>() { _mapper.Map<User, UserParticipantsResponce>(testUser) } ));


            var json = JsonConvert.SerializeObject(ids);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync($"api/user/getEventParticipants", data);
            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            var returnedJson = await response.Content.ReadAsStringAsync();
            var returnedUsers = JsonConvert.DeserializeObject<IEnumerable<UserResponse>>(returnedJson);
            Assert.NotNull(returnedUsers);
            Assert.Single(returnedUsers);
        }

        [Fact]
        public async Task GetEventParticipants_FoundNoUsers()
        {
            string[] ids = new string[] { "1", "2", "3" };
            _userServiceMock.Setup(userService => userService.GetUsersEventsParticipants(ids))
                .ReturnsAsync(Result<IEnumerable<UserParticipantsResponce>>.GetSuccess(Enumerable.Empty<UserParticipantsResponce>()));


            var json = JsonConvert.SerializeObject(ids);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync($"api/user/getEventParticipants", data);
            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            var returnedJson = await response.Content.ReadAsStringAsync();
            var returnedUsers = JsonConvert.DeserializeObject<IEnumerable<UserResponse>>(returnedJson);
            Assert.NotNull(returnedUsers);
            Assert.Empty(returnedUsers);
        }

        [Fact]
        public async Task Register_CorrectResponce()
        {
            var userToRegister = new RegisterModel() { Email = testUser.Email, Password = "pwd", Username = testUser.UserName };
            _userServiceMock.Setup(userService => userService.AddUser(It.IsAny<RegisterModel>()))
                .ReturnsAsync(Result<UserResponse>.GetSuccess(_mapper.Map<User, UserResponse>(testUser)));


            var json = JsonConvert.SerializeObject(userToRegister);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync($"api/user/register", data);
            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            var returnedJson = await response.Content.ReadAsStringAsync();
            var returnedUser = JsonConvert.DeserializeObject<UserResponse>(returnedJson);
            Assert.NotNull(returnedUser);
            Assert.Equal(testUser.UserName, returnedUser.Login);
            Assert.Equal(testUser.Id, returnedUser.Id);
            Assert.Equal(testUser.Email, returnedUser.Email);
        }

        [Fact]
        public async Task Register_Responce_UserAlreadyExists()
        {
            var userToRegister = new RegisterModel() { Email = testUser.Email, Password = "pwd", Username = testUser.UserName };
            _userServiceMock.Setup(userService => userService.AddUser(It.IsAny<RegisterModel>()))
                .ReturnsAsync(Result<UserResponse>.GetError(StatusCodes.Status500InternalServerError, "user already exists"));


            var json = JsonConvert.SerializeObject(userToRegister);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync($"api/user/register", data);
            ErrorResponceWithMessageExpected(response, HttpStatusCode.InternalServerError, "user already exists");
        }


        private async void ErrorResponceWithMessageExpected(HttpResponseMessage response, HttpStatusCode expectedStatusCode, string expectedMessage)
        {
            Assert.NotNull(response);
            Assert.NotNull(response.Content);
            var body = await response.Content.ReadAsStringAsync();
            var message = JsonConvert.DeserializeObject<List<string>>(body).FirstOrDefault();
            Assert.Equal(expectedStatusCode, response.StatusCode);
            Assert.Equal(expectedMessage, message);
        }

    }
}