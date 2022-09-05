using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Backend
{
    public class ApplicationDBContext : IdentityDbContext<User>
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        public new DbSet<User> Users { get; set; }
        public DbSet<EventDB> Events { get; set; }
        public DbSet<LocationDB> Locations { get; set; }
        public DbSet<EventParticipantsDB> EventParticipants { get; set; }
        public DbSet<FriendsDB> Friends { get; set; }
        public DbSet<FriendInvitationsDB> FriendInvitations { get; set; }
        public DbSet<ReviewsDB> Reviews { get; set; }
        public DbSet<CommentsDB> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>()
                 .HasMany(u => u.Events)
                 .WithOne(e => e.User)
                 .HasForeignKey(e => e.UserID);
            builder.Entity<User>()
                 .HasMany(u => u.Friends)
                 .WithOne(e => e.User)
                 .HasForeignKey(e => e.UserId);
            builder.Entity<User>()
                 .HasMany(u => u.FriendInvitations)
                 .WithOne(e => e.Author)
                 .HasForeignKey(e => e.AuthorId);
            builder.Entity<User>()
                 .HasMany(u => u.Comments)
                 .WithOne(e => e.Author)
                 .HasForeignKey(e => e.AuthorId);
            builder.Entity<EventDB>()
               .HasMany(u => u.Comments)
               .WithOne(e => e.Event)
               .HasForeignKey(e => e.EventId);
            builder.Entity<User>()
                 .HasMany(u => u.Reviews)
                 .WithOne(e => e.Author)
                 .HasForeignKey(e => e.AuthorId);
            builder.Entity<EventDB>()
                .HasMany(u => u.Reviews)
                .WithOne(e => e.Event)
                .HasForeignKey(e => e.EventId);
            builder.Entity<LocationDB>()
                 .HasMany(l => l.Events)
                 .WithOne(e => e.Location)
                 .HasForeignKey(e => e.LocationID);

            builder.Entity<EventParticipantsDB>()
                .HasOne(el => el.Event)
                .WithMany(el => el.EventParticipants)
                .HasForeignKey(el => el.EventId);

            builder.Entity<EventParticipantsDB>()
                .HasOne(el => el.User)
                .WithMany(el => el.EventParticipants)
                .HasForeignKey(el => el.UserId );

            builder.SeedAllData();
            base.OnModelCreating(builder);
        }
    }
}
