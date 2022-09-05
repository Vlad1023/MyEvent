using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Models;

namespace Backend.Services
{
    public interface IUserService
    {
        Task<Result<UserResponse>> GetUserByUsername(string username);
        Task<Result<UserResponse>> AddUser(RegisterModel registerModel);
        Task<Result<UserResponse>> LoginUser(LoginModel loginModel);
        Task<Result<UserResponse>> UpdateUser(string id, UpdateUser updatedModel);
        Task<Result<UserResponse>> GetUserById(string userId);
        Task<Result<IEnumerable<UserResponse>>> GetUsers();
        Task<Result<IEnumerable<UserResponse>>> GetUsersBySring(string toSearch);
        Task<Result<IEnumerable<UserParticipantsResponce>>> GetUsersEventsParticipants(string[] ids);
    }
}
