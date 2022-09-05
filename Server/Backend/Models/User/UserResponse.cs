using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Models
{
    public class UserResponse
    {
        public string Login { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        public string Id { get; set; }
    }
}
