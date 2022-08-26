using Backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Models;

namespace Tests
{
    public static class Common
    {
        public static Result<IEnumerable<UserResponse>> GetUsers()
        {
            var users = new List<UserResponse>()
            {
                new UserResponse{
                    Id = "1",
                    Email = "test@email.com",
                    Login = "test",
                    Token = "tokenTest"
                },
                 new UserResponse{
                    Id = "2",
                    Email = "test1@email.com",
                    Login = "test1",
                    Token = "token1Test"
                },
                  new UserResponse{
                    Id = "3",
                    Email = "test3@email.com",
                    Login = "test3",
                    Token = "token3Test"
                 }
            };
            return Result<IEnumerable<UserResponse>>.GetSuccess(users);
        }
    }
}
