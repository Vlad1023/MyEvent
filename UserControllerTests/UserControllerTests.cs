using AutoMapper;
using Backend;
using Backend.Models;
using Backend.Services;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Moq;
using Newtonsoft.Json;
using System.Net;
using Tests;

namespace UserControllerTests
{
    public class UserControllerTests : IAsyncLifetime
    {
        private readonly Mock<IUserService> _userServiceMock = new();

        private HttpClient _httpClient = null!;

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
                .ReturnsAsync(Common.GetUsers());

            var response = await _httpClient.GetAsync($"api/user/getUsers");
            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            var returnedJson = await response.Content.ReadAsStringAsync();
            var returnedUsers = JsonConvert.DeserializeObject<IEnumerable<UserResponse>>(returnedJson);
            Assert.NotNull(returnedUsers);
            Assert.Equal(returnedUsers.Count(), 3);
        }

        [Fact]
        private async Task GetUsers_ErrorResponce()
        {
            _userServiceMock.Setup(userService => userService.GetUsers())
                .ReturnsAsync(Result<IEnumerable<UserResponse>>.GetError(StatusCodes.Status500InternalServerError, "Users do not exist"));

            var response = await _httpClient.GetAsync($"api/profile/getUsers");
            Assert.Equal(HttpStatusCode.InternalServerError, response.StatusCode);
            Assert.Equal("Users do not exist", response.Content.ToString());
        }

    }
}