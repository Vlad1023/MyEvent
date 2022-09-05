using Backend.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IEventRepository Events { get; }
        ILocationRepository Locations { get; }
        IEventParticipantsRepository EventParticipants { get; }
        IReviewRepository Reviews { get; }
        IFriendRepository Friends { get; }
        IFriendInvitationsRepository FriendsInvitations { get; }
        ICommentRepository CommentRepository { get; }
        int Complete();
    }
}
