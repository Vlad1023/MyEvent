using Backend.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDBContext _context;
        public IEventRepository Events { get; }
        public ILocationRepository Locations { get; }
        public IEventParticipantsRepository EventParticipants { get; }

        public IReviewRepository Reviews { get; }
        public IFriendRepository Friends { get; }

        public IFriendInvitationsRepository FriendsInvitations { get; }

        public ICommentRepository CommentRepository { get; }

        public UnitOfWork(ApplicationDBContext appContext,
            IEventRepository eventsRepository, ILocationRepository locationRepository, IEventParticipantsRepository eventParticipantsRepository, IReviewRepository reviewRepository, IFriendRepository friendsRepository, IFriendInvitationsRepository friendInvitationsRepository, ICommentRepository commentRepository)
        {
            this._context = appContext;
            this.Events = eventsRepository;
            this.Locations = locationRepository;
            this.EventParticipants = eventParticipantsRepository;
            this.Reviews = reviewRepository;
            this.Friends = friendsRepository;
            this.FriendsInvitations = friendInvitationsRepository;
            this.CommentRepository = commentRepository;
        }
        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
    }
}
