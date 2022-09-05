using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Backend.Models;
using Backend.Models.Comments;
using Backend.Models.EventParticipants;
using Backend.Models.Invitation;
using Backend.Models.Review;
using Microsoft.AspNetCore.Identity;

namespace Backend
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<User, UserResponse>()
                .ForMember(user => user.Email, opt => opt.MapFrom(userResponse => userResponse.Email))
                .ForMember(user => user.Login, opt => opt.MapFrom(userResponse => userResponse.UserName))
                .ForMember(user => user.Id, opt => opt.MapFrom(userResponse => userResponse.Id));
            CreateMap<User, UserParticipantsResponce>()
                .ForMember(user => user.Name, opt => opt.MapFrom(userResponse => userResponse.UserName));
            CreateMap<UpdateUser, UserResponse>()
                .ForMember(user => user.Email, opt => opt.MapFrom(userResponse => userResponse.Email))
                .ForMember(user => user.Login, opt => opt.MapFrom(userResponse => userResponse.Username));
            CreateMap<EventDB, EventResponce>()
                .ForMember(ev => ev.AuthorId, ev => ev.MapFrom(ev1 => ev1.UserID))
                .ForMember(ev => ev.Description, ev => ev.MapFrom(ev1 => ev1.Description))
                .ForMember(ev => ev.StartDatetime, ev => ev.MapFrom(ev1 => ev1.StartDatetime))
                .ForMember(ev => ev.EndDatetime, ev => ev.MapFrom(ev1 => ev1.EndDatetime))
                .ForMember(ev => ev.EventName, ev => ev.MapFrom(ev1 => ev1.EventName))
                .ForMember(ev => ev.Rate, ev => ev.MapFrom(ev1 => ev1.Rate))
                .ForMember(ev => ev.LocationId, ev => ev.MapFrom(ev1 => ev1.LocationID))
                .ForMember(ev => ev.IsCancelled, ev => ev.MapFrom(ev1 => ev1.IsCancelled))
                .ForMember(ev => ev.isFinished, ev => ev.MapFrom(ev1 => ev1.isFinished))
                .ForMember(ev => ev.EventId, ev => ev.MapFrom(ev1 => ev1.EventId))
                .ForMember(ev => ev.ImagePath, ev => ev.MapFrom(ev1 => ev1.ImagePath))
                .ForMember(ev => ev.IsCreatedFromOriginal, ev => ev.MapFrom(ev1 => ev1.IsCreatedFromOriginal))
                .ForMember(ev => ev.OriginalEventId, ev => ev.MapFrom(ev1 => ev1.OriginalEventId))
                .ForMember(ev => ev.AdressShort, ev => ev.MapFrom(ev1 => ev1.Location.Adress));
            CreateMap<AddLocation, LocationDB>()
                .ForMember(ev => ev.Latitude, ev => ev.MapFrom(ev1 => ev1.Latitude))
                .ForMember(ev => ev.Longitude, ev => ev.MapFrom(ev1 => ev1.Longitude))
                .ForMember(ev => ev.Adress, ev => ev.MapFrom(ev1 => ev1.Adress));
            CreateMap<UpdateLocation, LocationDB>()
                .ForMember(ev => ev.Latitude, ev => ev.MapFrom(ev1 => ev1.Latitude))
                .ForMember(ev => ev.Longitude, ev => ev.MapFrom(ev1 => ev1.Longitude))
                .ForMember(ev => ev.Adress, ev => ev.MapFrom(ev1 => ev1.Adress));
            CreateMap<AddEvent, EventDB>()
                .ForMember(ev => ev.EventName, ev => ev.MapFrom(ev1 => ev1.EventName))
                .ForMember(ev => ev.Description, ev => ev.MapFrom(ev1 => ev1.Description))
                .ForMember(ev => ev.UserID, ev => ev.MapFrom(ev1 => ev1.UserID))
                .ForMember(ev => ev.StartDatetime, ev => ev.MapFrom(ev1 => ev1.StartDatetime))
                .ForMember(ev => ev.EndDatetime, ev => ev.MapFrom(ev1 => ev1.EndDatetime));
            CreateMap<UpdateEvent, EventDB>()
                .ForMember(ev => ev.EventName, ev => ev.MapFrom(ev1 => ev1.EventName))
                .ForMember(ev => ev.Description, ev => ev.MapFrom(ev1 => ev1.Description))
                .ForMember(ev => ev.StartDatetime, ev => ev.MapFrom(ev1 => ev1.StartDatetime))
                .ForMember(ev => ev.EndDatetime, ev => ev.MapFrom(ev1 => ev1.EndDatetime));
            CreateMap<AddEventParticipant, EventParticipantsDB>()
                .ForMember(ev => ev.EventId, ev => ev.MapFrom(ev1 => ev1.EventId))
                .ForMember(ev => ev.UserId, ev => ev.MapFrom(ev1 => ev1.UserId));
            CreateMap<EventParticipantsDB, EventParticipantResponce>()
                .ForMember(ev => ev.EventParticipantsId, ev => ev.MapFrom(ev1 => ev1.EventParticipantsId))
                .ForMember(ev => ev.UserId, ev => ev.MapFrom(ev1 => ev1.UserId))
                .ForMember(ev => ev.EventId, ev => ev.MapFrom(ev1 => ev1.EventId));
            CreateMap<LocationDB, LocationResponce>()
                  .ForMember(ev => ev.LocationId, ev => ev.MapFrom(ev1 => ev1.LocationId))
                  .ForMember(ev => ev.Latitude, ev => ev.MapFrom(ev1 => ev1.Latitude))
                  .ForMember(ev => ev.Longitude, ev => ev.MapFrom(ev1 => ev1.Longitude))
                  .ForMember(ev => ev.Adress, ev => ev.MapFrom(ev1 => ev1.Adress));
            CreateMap<ReviewsDB, ReviewResponce>()
                  .ForMember(ev => ev.Rate, ev => ev.MapFrom(ev1 => ev1.Rate))
                  .ForMember(ev => ev.ReviewId, ev => ev.MapFrom(ev1 => ev1.ReviewId));
            CreateMap<AddReview, ReviewsDB>()
                  .ForMember(ev => ev.EventId, ev => ev.MapFrom(ev1 => ev1.EventId))
                  .ForMember(ev => ev.AuthorId, ev => ev.MapFrom(ev1 => ev1.AuthorId))
                  .ForMember(ev => ev.Rate, ev => ev.MapFrom(ev1 => ev1.Rate));
            CreateMap<FriendsDB, FriendsResponce>()
                    .ForMember(ev => ev.firstUserId, ev => ev.MapFrom(ev1 => ev1.UserId))
                    .ForMember(ev => ev.secondUserId, ev => ev.MapFrom(ev1 => ev1.UserFriendId));
            CreateMap<AddFriends, FriendsDB>()
                    .ForMember(ev => ev.UserId, ev => ev.MapFrom(ev1 => ev1.firstUserId))
                    .ForMember(ev => ev.UserFriendId, ev => ev.MapFrom(ev1 => ev1.secondUserId));
            CreateMap<AddFriendInvitations, FriendInvitationsDB>()
                  .ForMember(ev => ev.UserReceiverId, ev => ev.MapFrom(ev1 => ev1.UserReceiverId))
                  .ForMember(ev => ev.AuthorId, ev => ev.MapFrom(ev1 => ev1.AuthorId));
            CreateMap<UserResponse, UserFriendsInvitationResponce>()
                  .ForMember(ev => ev.AuthorEmail, ev => ev.MapFrom(ev1 => ev1.Email))
                  .ForMember(ev => ev.AuthorName, ev => ev.MapFrom(ev1 => ev1.Login));
            CreateMap<AddComment, CommentsDB>()
                .ForMember(ev => ev.AuthorId, ev => ev.MapFrom(ev1 => ev1.AuthorId))
                .ForMember(ev => ev.Comment, ev => ev.MapFrom(ev1 => ev1.Comment))
                .ForMember(ev => ev.DateAdded, ev => ev.MapFrom(ev1 => DateTime.Now))
                .ForMember(ev => ev.EventId, ev => ev.MapFrom(ev1 => ev1.EventId));
            CreateMap<CommentsDB, CommentResponce>()
                .ForMember(ev => ev.Comment, ev => ev.MapFrom(ev1 => ev1.Comment))
                .ForMember(ev => ev.DateAdded, ev => ev.MapFrom(ev1 => ev1.DateAdded))
                .ForMember(ev => ev.CommentId, ev => ev.MapFrom(ev1 => ev1.CommentId));

        }
    }
}
