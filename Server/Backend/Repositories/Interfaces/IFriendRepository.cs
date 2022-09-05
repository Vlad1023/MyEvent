using Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Repositories.Interfaces
{
    public interface IFriendRepository : IGenericRepository<FriendsDB>
    {
        IEnumerable<FriendsDB> GetUserFriends(string userId);
    }
}
