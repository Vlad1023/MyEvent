using Backend.Models;
using Backend.Models;
using Backend.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend
{
    public static class Extencions
    {
        static string Test1UserKey = "b74ddd14-6340-4840-95c2-db12554843e5";
        static string Test2UserKey = "c74ddf14-6340-4840-95c2-db12554843e5";

        static string Password = "1k1YtpmfCm.@";
        public static void SeedAllData(this ModelBuilder modelBuilder)
        {
            User user1 = new User()
            {
                Id = Test1UserKey,
                UserName = "Test1",
                Email = "volkovskiy4@gmail.com",
                NormalizedEmail = "VOLKOVSKIY4@GMAIL.COM",
                NormalizedUserName = "TEST1",
                LockoutEnabled = false,
                PhoneNumber = null
            };
            User user2 = new User()
            {
                Id = Test2UserKey,
                UserName = "Test2",
                Email = "volkovskiy4@gmail.com",
                NormalizedEmail = "VOLKOVSKIY4@GMAIL.COM",
                NormalizedUserName = "TEST2",
                LockoutEnabled = false,
                PhoneNumber = null
            };
            PasswordHasher<User> passwordHasher
                    = new PasswordHasher<User>(
                Options.Create(new PasswordHasherOptions()
                {
                    CompatibilityMode = PasswordHasherCompatibilityMode.IdentityV2,
                }));


            user1.SecurityStamp = Guid.NewGuid().ToString();
            user1.PasswordHash = passwordHasher.HashPassword(user1, Password);
            user2.SecurityStamp = Guid.NewGuid().ToString();
            user2.PasswordHash = passwordHasher.HashPassword(user2, Password);

            modelBuilder.Entity<User>().HasData(user1);
            modelBuilder.Entity<User>().HasData(user2);

            modelBuilder.Entity<LocationDB>().HasData(
            new LocationDB { LocationId = "1", Latitude = 49.068765, Longitude = 28.802314, Adress = "Vinnytsia Oblast" });
            modelBuilder.Entity<EventDB>().HasData(
            new EventDB { EventId = "1", Description = "When the game is brought up, at least one person recalls playing it, or something similar, when they were young. I assure you the game is not the same as an adult, when personalities and thought processes are, hopefully, more developed. The game itself was allegedly created by Dmitry Davidoff of the Moscow State University Psychology Department as a research project, and then eventually spread to college campuses in Europe and the United States. It had a heyday in the '90s, along with everything else cool in the world. I hadn’t heard of it until one afternoon this past summer while I was hanging out with friends in Bolinas and it was proposed we play. It was that afternoon that my life changed forever, in a fun-game kind of way. Although there are many variations, I’m going to teach you to play the way my friends and I play, so then you’ll know and we can play together because we always need more players; seriously, it’s super hard to get that many people in a room!", EventName = "Mafia game", Rate = 4.5f, StartDatetime = DateTime.Now, EndDatetime = DateTime.Now.AddSeconds(30), LocationID = "1", UserID = Test1UserKey, ImagePath = "http://127.0.0.1:10000/devstoreaccount1/eventsimages/c3cefc9f-ec6d-4d2d-a338-2e82bdaab3f8Wallpaper.jpg?sv=2018-03-28&st=2022-05-15T19%3A08%3A40Z&se=2022-12-24T20%3A08%3A00Z&sr=c&sp=racwdl&sig=lmj94GQWm6FwAD4z0ZmBRQPJYL0g2%2BD%2BAp5zkdw2kiY%3D", isFinished = false, IsCancelled = false },
            new EventDB { EventId = "2", Description = "When the game is brought up, at least one person recalls playing it, or something similar, when they were young. I assure you the game is not the same as an adult, when personalities and thought processes are, hopefully, more developed. The game itself was allegedly created by Dmitry Davidoff of the Moscow State University Psychology Department as a research project, and then eventually spread to college campuses in Europe and the United States. It had a heyday in the '90s, along with everything else cool in the world. I hadn’t heard of it until one afternoon this past summer while I was hanging out with friends in Bolinas and it was proposed we play. It was that afternoon that my life changed forever, in a fun-game kind of way. Although there are many variations, I’m going to teach you to play the way my friends and I play, so then you’ll know and we can play together because we always need more players; seriously, it’s super hard to get that many people in a room!", EventName = "Mafia game2", Rate = 4.5f, StartDatetime = DateTime.Now.AddHours(30), EndDatetime = DateTime.Now.AddHours(55), LocationID = "1", UserID = Test1UserKey, ImagePath = "http://127.0.0.1:10000/devstoreaccount1/eventsimages/c3cefc9f-ec6d-4d2d-a338-2e82bdaab3f8Wallpaper.jpg?sv=2018-03-28&st=2022-05-15T19%3A08%3A40Z&se=2022-12-24T20%3A08%3A00Z&sr=c&sp=racwdl&sig=lmj94GQWm6FwAD4z0ZmBRQPJYL0g2%2BD%2BAp5zkdw2kiY%3D", isFinished = false, IsCancelled = false },
            new EventDB { EventId = "3", Description = "When the game is brought up, at least one person recalls playing it, or something similar, when they were young. I assure you the game is not the same as an adult, when personalities and thought processes are, hopefully, more developed. The game itself was allegedly created by Dmitry Davidoff of the Moscow State University Psychology Department as a research project, and then eventually spread to college campuses in Europe and the United States. It had a heyday in the '90s, along with everything else cool in the world. I hadn’t heard of it until one afternoon this past summer while I was hanging out with friends in Bolinas and it was proposed we play. It was that afternoon that my life changed forever, in a fun-game kind of way. Although there are many variations, I’m going to teach you to play the way my friends and I play, so then you’ll know and we can play together because we always need more players; seriously, it’s super hard to get that many people in a room!", EventName = "Mafia game3", Rate = 4.5f, StartDatetime = DateTime.Now.AddHours(30), EndDatetime = DateTime.Now.AddHours(55), LocationID = "1", UserID = Test1UserKey, ImagePath = "http://127.0.0.1:10000/devstoreaccount1/eventsimages/c3cefc9f-ec6d-4d2d-a338-2e82bdaab3f8Wallpaper.jpg?sv=2018-03-28&st=2022-05-15T19%3A08%3A40Z&se=2022-12-24T20%3A08%3A00Z&sr=c&sp=racwdl&sig=lmj94GQWm6FwAD4z0ZmBRQPJYL0g2%2BD%2BAp5zkdw2kiY%3D", isFinished = false, IsCancelled = false },
            new EventDB { EventId = "4", Description = "When the game is brought up, at least one person recalls playing it, or something similar, when they were young. I assure you the game is not the same as an adult, when personalities and thought processes are, hopefully, more developed. The game itself was allegedly created by Dmitry Davidoff of the Moscow State University Psychology Department as a research project, and then eventually spread to college campuses in Europe and the United States. It had a heyday in the '90s, along with everything else cool in the world. I hadn’t heard of it until one afternoon this past summer while I was hanging out with friends in Bolinas and it was proposed we play. It was that afternoon that my life changed forever, in a fun-game kind of way. Although there are many variations, I’m going to teach you to play the way my friends and I play, so then you’ll know and we can play together because we always need more players; seriously, it’s super hard to get that many people in a room!", EventName = "Mafia game4", Rate = 4.5f, StartDatetime = DateTime.Now.AddHours(30), EndDatetime = DateTime.Now.AddHours(55), LocationID = "1", UserID = Test1UserKey, ImagePath = "http://127.0.0.1:10000/devstoreaccount1/eventsimages/c3cefc9f-ec6d-4d2d-a338-2e82bdaab3f8Wallpaper.jpg?sv=2018-03-28&st=2022-05-15T19%3A08%3A40Z&se=2022-12-24T20%3A08%3A00Z&sr=c&sp=racwdl&sig=lmj94GQWm6FwAD4z0ZmBRQPJYL0g2%2BD%2BAp5zkdw2kiY%3D", isFinished = false, IsCancelled = false },
            new EventDB { EventId = "5", Description = "When the game is brought up, at least one person recalls playing it, or something similar, when they were young. I assure you the game is not the same as an adult, when personalities and thought processes are, hopefully, more developed. The game itself was allegedly created by Dmitry Davidoff of the Moscow State University Psychology Department as a research project, and then eventually spread to college campuses in Europe and the United States. It had a heyday in the '90s, along with everything else cool in the world. I hadn’t heard of it until one afternoon this past summer while I was hanging out with friends in Bolinas and it was proposed we play. It was that afternoon that my life changed forever, in a fun-game kind of way. Although there are many variations, I’m going to teach you to play the way my friends and I play, so then you’ll know and we can play together because we always need more players; seriously, it’s super hard to get that many people in a room!", EventName = "Mafia game5", Rate = 4.5f, StartDatetime = DateTime.Now.AddHours(30), EndDatetime = DateTime.Now.AddHours(55), LocationID = "1", UserID = Test1UserKey, ImagePath = "http://127.0.0.1:10000/devstoreaccount1/eventsimages/c3cefc9f-ec6d-4d2d-a338-2e82bdaab3f8Wallpaper.jpg?sv=2018-03-28&st=2022-05-15T19%3A08%3A40Z&se=2022-12-24T20%3A08%3A00Z&sr=c&sp=racwdl&sig=lmj94GQWm6FwAD4z0ZmBRQPJYL0g2%2BD%2BAp5zkdw2kiY%3D", isFinished = false, IsCancelled = false },
            new EventDB { EventId = "6", Description = "When the game is brought up, at least one person recalls playing it, or something similar, when they were young. I assure you the game is not the same as an adult, when personalities and thought processes are, hopefully, more developed. The game itself was allegedly created by Dmitry Davidoff of the Moscow State University Psychology Department as a research project, and then eventually spread to college campuses in Europe and the United States. It had a heyday in the '90s, along with everything else cool in the world. I hadn’t heard of it until one afternoon this past summer while I was hanging out with friends in Bolinas and it was proposed we play. It was that afternoon that my life changed forever, in a fun-game kind of way. Although there are many variations, I’m going to teach you to play the way my friends and I play, so then you’ll know and we can play together because we always need more players; seriously, it’s super hard to get that many people in a room!", EventName = "Mafia game6", Rate = 4.5f, StartDatetime = DateTime.Now.AddHours(30), EndDatetime = DateTime.Now.AddHours(55), LocationID = "1", UserID = Test1UserKey, ImagePath = "http://127.0.0.1:10000/devstoreaccount1/eventsimages/c3cefc9f-ec6d-4d2d-a338-2e82bdaab3f8Wallpaper.jpg?sv=2018-03-28&st=2022-05-15T19%3A08%3A40Z&se=2022-12-24T20%3A08%3A00Z&sr=c&sp=racwdl&sig=lmj94GQWm6FwAD4z0ZmBRQPJYL0g2%2BD%2BAp5zkdw2kiY%3D", isFinished = false, IsCancelled = false },
            new EventDB { EventId = "7", Description = "When the game is brought up, at least one person recalls playing it, or something similar, when they were young. I assure you the game is not the same as an adult, when personalities and thought processes are, hopefully, more developed. The game itself was allegedly created by Dmitry Davidoff of the Moscow State University Psychology Department as a research project, and then eventually spread to college campuses in Europe and the United States. It had a heyday in the '90s, along with everything else cool in the world. I hadn’t heard of it until one afternoon this past summer while I was hanging out with friends in Bolinas and it was proposed we play. It was that afternoon that my life changed forever, in a fun-game kind of way. Although there are many variations, I’m going to teach you to play the way my friends and I play, so then you’ll know and we can play together because we always need more players; seriously, it’s super hard to get that many people in a room!", EventName = "Mafia game7", Rate = 4.5f, StartDatetime = DateTime.Now.AddHours(-2), EndDatetime = DateTime.Now.AddHours(-1), LocationID = "1", UserID = Test1UserKey, ImagePath = "http://127.0.0.1:10000/devstoreaccount1/eventsimages/c3cefc9f-ec6d-4d2d-a338-2e82bdaab3f8Wallpaper.jpg?sv=2018-03-28&st=2022-05-15T19%3A08%3A40Z&se=2022-12-24T20%3A08%3A00Z&sr=c&sp=racwdl&sig=lmj94GQWm6FwAD4z0ZmBRQPJYL0g2%2BD%2BAp5zkdw2kiY%3D", isFinished = true, IsCancelled = false },
            new EventDB { EventId = "8", Description = "When the game is brought up, at least one person recalls playing it, or something similar, when they were young. I assure you the game is not the same as an adult, when personalities and thought processes are, hopefully, more developed. The game itself was allegedly created by Dmitry Davidoff of the Moscow State University Psychology Department as a research project, and then eventually spread to college campuses in Europe and the United States. It had a heyday in the '90s, along with everything else cool in the world. I hadn’t heard of it until one afternoon this past summer while I was hanging out with friends in Bolinas and it was proposed we play. It was that afternoon that my life changed forever, in a fun-game kind of way. Although there are many variations, I’m going to teach you to play the way my friends and I play, so then you’ll know and we can play together because we always need more players; seriously, it’s super hard to get that many people in a room!", EventName = "Mafia game8", Rate = 4.5f, StartDatetime = DateTime.Now.AddHours(-2), EndDatetime = DateTime.Now.AddHours(-1), LocationID = "1", UserID = Test1UserKey, ImagePath = "http://127.0.0.1:10000/devstoreaccount1/eventsimages/c3cefc9f-ec6d-4d2d-a338-2e82bdaab3f8Wallpaper.jpg?sv=2018-03-28&st=2022-05-15T19%3A08%3A40Z&se=2022-12-24T20%3A08%3A00Z&sr=c&sp=racwdl&sig=lmj94GQWm6FwAD4z0ZmBRQPJYL0g2%2BD%2BAp5zkdw2kiY%3D", isFinished = true, IsCancelled = false }
            );

            modelBuilder.Entity<EventParticipantsDB>().HasData(
                new EventParticipantsDB { EventParticipantsId = "9", EventId = "1", UserId = Test2UserKey },
                new EventParticipantsDB { EventParticipantsId = "10", EventId = "2", UserId = Test2UserKey },
                new EventParticipantsDB { EventParticipantsId = "11", EventId = "7", UserId = Test2UserKey },
                new EventParticipantsDB { EventParticipantsId = "12", EventId = "8", UserId = Test2UserKey }
                );
        }
    }
}
