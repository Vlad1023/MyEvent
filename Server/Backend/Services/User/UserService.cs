using Backend.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using AutoMapper;

namespace Backend.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;
        private readonly IHttpContextAccessor __contextAccessor;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;
        public UserService(IHttpContextAccessor contextAccessor, UserManager<User> userManager, IConfiguration configuration, IMapper mapper)
        {
            this._userManager = userManager;
            this._configuration = configuration;
            this._mapper = mapper;
            this.__contextAccessor = contextAccessor;
        }
        public async Task<Result<UserResponse>> AddUser(RegisterModel registerModel)
        {
            var userExists = await _userManager.FindByNameAsync(registerModel.Username);
            if (userExists != null)
                return Result<UserResponse>.GetError(StatusCodes.Status500InternalServerError, "user already exists");
            User user = new User()
            {
                Email = registerModel.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = registerModel.Username
            };
            var result = await _userManager.CreateAsync(user, registerModel.Password);
            if (!result.Succeeded)
                return Result<UserResponse>.GetError(StatusCodes.Status500InternalServerError, result.Errors.Select(el => el.Description));

            return Result<UserResponse>.GetSuccess(this._mapper.Map<UserResponse>(user));
        }

        public async Task<Result<UserResponse>> GetUserByUsername(string username)
        {
            var userExists = await _userManager.FindByNameAsync(username);
            if (userExists == null)
                return Result<UserResponse>.GetError(StatusCodes.Status500InternalServerError, "Such user does not exist");
            return Result<UserResponse>.GetSuccess(_mapper.Map<UserResponse>(userExists));

        }
        public async Task<Result<UserResponse>> GetUserById(string userId)
        {
            var userExists = await _userManager.FindByIdAsync(userId);
            if (userExists == null)
                return Result<UserResponse>.GetError(StatusCodes.Status500InternalServerError, "Such user does not exist");
            return Result<UserResponse>.GetSuccess(_mapper.Map<UserResponse>(userExists));

        }

        public async Task<Result<IEnumerable<UserResponse>>> GetUsers()
        {
            var userExists = _userManager.Users;
            if (userExists == null)
                return Result<IEnumerable<UserResponse>>.GetError(StatusCodes.Status500InternalServerError, "Users do not exist");
            return Result<IEnumerable<UserResponse>>.GetSuccess(_mapper.Map<IEnumerable<UserResponse>>(userExists));
        }

        public async Task<Result<UserResponse>> UpdateUser(string id, UpdateUser updatedModel)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            if(user == null)
                return Result<UserResponse>.GetError(StatusCodes.Status500InternalServerError, "Such user does not exist");
            UpdateUserFromUpdateUserModel(updatedModel, user);
            var userResult = await _userManager.UpdateAsync(_mapper.Map<User>(user));
            if (userResult.Succeeded)
                return Result<UserResponse>.GetSuccess(_mapper.Map<UserResponse>(userResult));
            return Result<UserResponse>.GetError(StatusCodes.Status500InternalServerError, userResult.Errors.FirstOrDefault().ToString());
        }

        public async Task<Result<UserResponse>> LoginUser(LoginModel loginModel)
        {
            var user = await _userManager.FindByNameAsync(loginModel.Username);
            if (user != null && await _userManager.CheckPasswordAsync(user, loginModel.Password))
            {
                var userRoles = await _userManager.GetRolesAsync(user);

                var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

                //var authClaims = DefineUserClaims(user, userRoles);
                var authClaims = DefineUserClaims(user, null);

                var token = new JwtSecurityToken(
                    issuer: _configuration["JWT:ValidIssuer"],
                    audience: _configuration["JWT:ValidAudience"],
                    expires: DateTime.Now.AddMinutes(Int32.Parse(_configuration["JWT:ValidTime"])),
                    claims: authClaims,
                    signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                    );

                var userResponce = _mapper.Map<UserResponse>(user);
                userResponce.Token = new JwtSecurityTokenHandler().WriteToken(token);

                return Result<UserResponse>.GetSuccess(userResponce);
            }
            return Result<UserResponse>.GetError(StatusCodes.Status404NotFound, "Such user does not exist");
        }

        private IEnumerable<Claim> DefineUserClaims(in User user, IEnumerable<string> userRoles)
        {
            var authClaims = new List<Claim>
                {
                    new Claim("Username", user.UserName),
                    new Claim("UserId", user.Id.ToString()),
                    new Claim("Email", user.Email)
                };

            //foreach (var userRole in userRoles)
            //{
            //    authClaims.Add(new Claim(ClaimTypes.Role, userRole));
            //}
            return authClaims;
        }

        private void UpdateUserFromUpdateUserModel(UpdateUser updateUser, User user)
        {
            user.UserName = updateUser.Username;
            user.Email = updateUser.Email;
        }

        public async Task<Result<IEnumerable<UserParticipantsResponce>>> GetUsersEventsParticipants(string[] ids)
        {
            var userList = new List<User>();
            foreach (var item in ids)
            {
                var user = await _userManager.FindByIdAsync(item);
                userList.Add(user);
            }
            return Result<IEnumerable<UserParticipantsResponce>>.GetSuccess(_mapper.Map<IEnumerable<UserParticipantsResponce>>(userList));
        }

        public async Task<Result<IEnumerable<UserResponse>>> GetUsersBySring(string toSearch)
        {
            var allUsers = await this.GetUsers();
            if (toSearch == null || toSearch == String.Empty)
                return Result<IEnumerable<UserResponse>>.GetSuccess(Enumerable.Empty<UserResponse>());
            return Result<IEnumerable<UserResponse>>.GetSuccess(allUsers.Data.Where(el => el.Login.Contains(toSearch)).ToList());
        }
    }
}
