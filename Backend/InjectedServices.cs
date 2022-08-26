using Azure.Storage.Blobs;
using Backend.Repositories;
using Backend.Repositories.Interfaces;
using Backend.Services;
using Backend.Services.BlobService;
using Backend.Services.Comments;
using Backend.Services.Email;
using Backend.Services.Event;
using Backend.Services.Friends;
using Microsoft.Extensions.Azure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend
{
    public static class InjectedServices
    {
        public static void InjectServices(in IServiceCollection servicesCollection, IConfiguration configuration)
        {
            servicesCollection.AddTransient<IUserService, UserService>();
            servicesCollection.AddTransient<IEventService, EventService>();
            servicesCollection.AddTransient<IUnitOfWork, UnitOfWork>();
            servicesCollection.AddTransient<IEventRepository, EventsRepository>();
            servicesCollection.AddTransient<ILocationRepository, LocationRepository>();
            servicesCollection.AddTransient<IEventParticipantsRepository, EventParticipantsRepository>();
            servicesCollection.AddTransient<IEmailService, EmailService>();
            servicesCollection.AddTransient<IReviewService, ReviewService>();
            servicesCollection.AddTransient<IReviewRepository, ReviewRepository>();
            servicesCollection.AddTransient<IFriendRepository, FriendsRepository>();
            servicesCollection.AddTransient<IFriendsService, FriendsService>();
            servicesCollection.AddTransient<IFriendInvitationsRepository, FriendInvitationRepository>();
            servicesCollection.AddTransient<ICommentService, CommentService>();
            servicesCollection.AddTransient<ICommentRepository, CommentRepository>();
            servicesCollection.AddHostedService<BackgroundEventService>();

            if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Develoment")
            {
                servicesCollection.AddAzureClients(builder =>
                {
                    builder.AddBlobServiceClient(configuration["StorageConnectionString:blob"], preferMsi: true);
                    builder.AddQueueServiceClient(configuration["StorageConnectionString:queue"], preferMsi: true);
                });
                servicesCollection.AddTransient<IBlobService, BlobServiceLocal>();
            }
            else
            {
                servicesCollection.AddSingleton(x => new BlobServiceClient(configuration.GetConnectionString("AzureConnectionStringToBlobService")));

                servicesCollection.AddTransient<IBlobService, BlobServiceProd>();
            }
        }
    }
}
