﻿// <auto-generated />
using System;
using Backend;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Backend.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20220607234006_AddEntities")]
    partial class AddEntities
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Backend.Models.CommentsDB", b =>
                {
                    b.Property<string>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AuthorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CommentId");

                    b.HasIndex("AuthorId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Backend.Models.EventDB", b =>
                {
                    b.Property<string>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDatetime")
                        .HasColumnType("datetime2");

                    b.Property<string>("EventName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsCancelled")
                        .HasColumnType("bit");

                    b.Property<bool>("IsCreatedFromOriginal")
                        .HasColumnType("bit");

                    b.Property<string>("LocationID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<float>("Rate")
                        .HasColumnType("real");

                    b.Property<DateTime>("StartDatetime")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("isFinished")
                        .HasColumnType("bit");

                    b.HasKey("EventId");

                    b.HasIndex("LocationID");

                    b.HasIndex("UserID");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            EventId = "1",
                            Description = "When the game is brought up, at least one person recalls playing it, or something similar, when they were young. I assure you the game is not the same as an adult, when personalities and thought processes are, hopefully, more developed. The game itself was allegedly created by Dmitry Davidoff of the Moscow State University Psychology Department as a research project, and then eventually spread to college campuses in Europe and the United States. It had a heyday in the '90s, along with everything else cool in the world. I hadn’t heard of it until one afternoon this past summer while I was hanging out with friends in Bolinas and it was proposed we play. It was that afternoon that my life changed forever, in a fun-game kind of way. Although there are many variations, I’m going to teach you to play the way my friends and I play, so then you’ll know and we can play together because we always need more players; seriously, it’s super hard to get that many people in a room!",
                            EndDatetime = new DateTime(2022, 6, 8, 2, 40, 35, 772, DateTimeKind.Local).AddTicks(8235),
                            EventName = "Mafia game",
                            ImagePath = "http://127.0.0.1:10000/devstoreaccount1/eventsimages/c3cefc9f-ec6d-4d2d-a338-2e82bdaab3f8Wallpaper.jpg?sv=2018-03-28&st=2022-05-15T19%3A08%3A40Z&se=2022-12-24T20%3A08%3A00Z&sr=c&sp=racwdl&sig=lmj94GQWm6FwAD4z0ZmBRQPJYL0g2%2BD%2BAp5zkdw2kiY%3D",
                            IsCancelled = false,
                            IsCreatedFromOriginal = false,
                            LocationID = "1",
                            Rate = 4.5f,
                            StartDatetime = new DateTime(2022, 6, 8, 2, 40, 5, 770, DateTimeKind.Local).AddTicks(1175),
                            UserID = "b74ddd14-6340-4840-95c2-db12554843e5",
                            isFinished = false
                        },
                        new
                        {
                            EventId = "2",
                            Description = "When the game is brought up, at least one person recalls playing it, or something similar, when they were young. I assure you the game is not the same as an adult, when personalities and thought processes are, hopefully, more developed. The game itself was allegedly created by Dmitry Davidoff of the Moscow State University Psychology Department as a research project, and then eventually spread to college campuses in Europe and the United States. It had a heyday in the '90s, along with everything else cool in the world. I hadn’t heard of it until one afternoon this past summer while I was hanging out with friends in Bolinas and it was proposed we play. It was that afternoon that my life changed forever, in a fun-game kind of way. Although there are many variations, I’m going to teach you to play the way my friends and I play, so then you’ll know and we can play together because we always need more players; seriously, it’s super hard to get that many people in a room!",
                            EndDatetime = new DateTime(2022, 6, 10, 9, 40, 5, 773, DateTimeKind.Local).AddTicks(375),
                            EventName = "Mafia game2",
                            ImagePath = "http://127.0.0.1:10000/devstoreaccount1/eventsimages/c3cefc9f-ec6d-4d2d-a338-2e82bdaab3f8Wallpaper.jpg?sv=2018-03-28&st=2022-05-15T19%3A08%3A40Z&se=2022-12-24T20%3A08%3A00Z&sr=c&sp=racwdl&sig=lmj94GQWm6FwAD4z0ZmBRQPJYL0g2%2BD%2BAp5zkdw2kiY%3D",
                            IsCancelled = false,
                            IsCreatedFromOriginal = false,
                            LocationID = "1",
                            Rate = 4.5f,
                            StartDatetime = new DateTime(2022, 6, 9, 8, 40, 5, 773, DateTimeKind.Local).AddTicks(349),
                            UserID = "b74ddd14-6340-4840-95c2-db12554843e5",
                            isFinished = false
                        },
                        new
                        {
                            EventId = "3",
                            Description = "When the game is brought up, at least one person recalls playing it, or something similar, when they were young. I assure you the game is not the same as an adult, when personalities and thought processes are, hopefully, more developed. The game itself was allegedly created by Dmitry Davidoff of the Moscow State University Psychology Department as a research project, and then eventually spread to college campuses in Europe and the United States. It had a heyday in the '90s, along with everything else cool in the world. I hadn’t heard of it until one afternoon this past summer while I was hanging out with friends in Bolinas and it was proposed we play. It was that afternoon that my life changed forever, in a fun-game kind of way. Although there are many variations, I’m going to teach you to play the way my friends and I play, so then you’ll know and we can play together because we always need more players; seriously, it’s super hard to get that many people in a room!",
                            EndDatetime = new DateTime(2022, 6, 10, 9, 40, 5, 773, DateTimeKind.Local).AddTicks(385),
                            EventName = "Mafia game3",
                            ImagePath = "http://127.0.0.1:10000/devstoreaccount1/eventsimages/c3cefc9f-ec6d-4d2d-a338-2e82bdaab3f8Wallpaper.jpg?sv=2018-03-28&st=2022-05-15T19%3A08%3A40Z&se=2022-12-24T20%3A08%3A00Z&sr=c&sp=racwdl&sig=lmj94GQWm6FwAD4z0ZmBRQPJYL0g2%2BD%2BAp5zkdw2kiY%3D",
                            IsCancelled = false,
                            IsCreatedFromOriginal = false,
                            LocationID = "1",
                            Rate = 4.5f,
                            StartDatetime = new DateTime(2022, 6, 9, 8, 40, 5, 773, DateTimeKind.Local).AddTicks(381),
                            UserID = "b74ddd14-6340-4840-95c2-db12554843e5",
                            isFinished = false
                        },
                        new
                        {
                            EventId = "4",
                            Description = "When the game is brought up, at least one person recalls playing it, or something similar, when they were young. I assure you the game is not the same as an adult, when personalities and thought processes are, hopefully, more developed. The game itself was allegedly created by Dmitry Davidoff of the Moscow State University Psychology Department as a research project, and then eventually spread to college campuses in Europe and the United States. It had a heyday in the '90s, along with everything else cool in the world. I hadn’t heard of it until one afternoon this past summer while I was hanging out with friends in Bolinas and it was proposed we play. It was that afternoon that my life changed forever, in a fun-game kind of way. Although there are many variations, I’m going to teach you to play the way my friends and I play, so then you’ll know and we can play together because we always need more players; seriously, it’s super hard to get that many people in a room!",
                            EndDatetime = new DateTime(2022, 6, 10, 9, 40, 5, 773, DateTimeKind.Local).AddTicks(393),
                            EventName = "Mafia game4",
                            ImagePath = "http://127.0.0.1:10000/devstoreaccount1/eventsimages/c3cefc9f-ec6d-4d2d-a338-2e82bdaab3f8Wallpaper.jpg?sv=2018-03-28&st=2022-05-15T19%3A08%3A40Z&se=2022-12-24T20%3A08%3A00Z&sr=c&sp=racwdl&sig=lmj94GQWm6FwAD4z0ZmBRQPJYL0g2%2BD%2BAp5zkdw2kiY%3D",
                            IsCancelled = false,
                            IsCreatedFromOriginal = false,
                            LocationID = "1",
                            Rate = 4.5f,
                            StartDatetime = new DateTime(2022, 6, 9, 8, 40, 5, 773, DateTimeKind.Local).AddTicks(390),
                            UserID = "b74ddd14-6340-4840-95c2-db12554843e5",
                            isFinished = false
                        },
                        new
                        {
                            EventId = "5",
                            Description = "When the game is brought up, at least one person recalls playing it, or something similar, when they were young. I assure you the game is not the same as an adult, when personalities and thought processes are, hopefully, more developed. The game itself was allegedly created by Dmitry Davidoff of the Moscow State University Psychology Department as a research project, and then eventually spread to college campuses in Europe and the United States. It had a heyday in the '90s, along with everything else cool in the world. I hadn’t heard of it until one afternoon this past summer while I was hanging out with friends in Bolinas and it was proposed we play. It was that afternoon that my life changed forever, in a fun-game kind of way. Although there are many variations, I’m going to teach you to play the way my friends and I play, so then you’ll know and we can play together because we always need more players; seriously, it’s super hard to get that many people in a room!",
                            EndDatetime = new DateTime(2022, 6, 10, 9, 40, 5, 773, DateTimeKind.Local).AddTicks(401),
                            EventName = "Mafia game5",
                            ImagePath = "http://127.0.0.1:10000/devstoreaccount1/eventsimages/c3cefc9f-ec6d-4d2d-a338-2e82bdaab3f8Wallpaper.jpg?sv=2018-03-28&st=2022-05-15T19%3A08%3A40Z&se=2022-12-24T20%3A08%3A00Z&sr=c&sp=racwdl&sig=lmj94GQWm6FwAD4z0ZmBRQPJYL0g2%2BD%2BAp5zkdw2kiY%3D",
                            IsCancelled = false,
                            IsCreatedFromOriginal = false,
                            LocationID = "1",
                            Rate = 4.5f,
                            StartDatetime = new DateTime(2022, 6, 9, 8, 40, 5, 773, DateTimeKind.Local).AddTicks(398),
                            UserID = "b74ddd14-6340-4840-95c2-db12554843e5",
                            isFinished = false
                        },
                        new
                        {
                            EventId = "6",
                            Description = "When the game is brought up, at least one person recalls playing it, or something similar, when they were young. I assure you the game is not the same as an adult, when personalities and thought processes are, hopefully, more developed. The game itself was allegedly created by Dmitry Davidoff of the Moscow State University Psychology Department as a research project, and then eventually spread to college campuses in Europe and the United States. It had a heyday in the '90s, along with everything else cool in the world. I hadn’t heard of it until one afternoon this past summer while I was hanging out with friends in Bolinas and it was proposed we play. It was that afternoon that my life changed forever, in a fun-game kind of way. Although there are many variations, I’m going to teach you to play the way my friends and I play, so then you’ll know and we can play together because we always need more players; seriously, it’s super hard to get that many people in a room!",
                            EndDatetime = new DateTime(2022, 6, 10, 9, 40, 5, 773, DateTimeKind.Local).AddTicks(410),
                            EventName = "Mafia game6",
                            ImagePath = "http://127.0.0.1:10000/devstoreaccount1/eventsimages/c3cefc9f-ec6d-4d2d-a338-2e82bdaab3f8Wallpaper.jpg?sv=2018-03-28&st=2022-05-15T19%3A08%3A40Z&se=2022-12-24T20%3A08%3A00Z&sr=c&sp=racwdl&sig=lmj94GQWm6FwAD4z0ZmBRQPJYL0g2%2BD%2BAp5zkdw2kiY%3D",
                            IsCancelled = false,
                            IsCreatedFromOriginal = false,
                            LocationID = "1",
                            Rate = 4.5f,
                            StartDatetime = new DateTime(2022, 6, 9, 8, 40, 5, 773, DateTimeKind.Local).AddTicks(405),
                            UserID = "b74ddd14-6340-4840-95c2-db12554843e5",
                            isFinished = false
                        },
                        new
                        {
                            EventId = "7",
                            Description = "When the game is brought up, at least one person recalls playing it, or something similar, when they were young. I assure you the game is not the same as an adult, when personalities and thought processes are, hopefully, more developed. The game itself was allegedly created by Dmitry Davidoff of the Moscow State University Psychology Department as a research project, and then eventually spread to college campuses in Europe and the United States. It had a heyday in the '90s, along with everything else cool in the world. I hadn’t heard of it until one afternoon this past summer while I was hanging out with friends in Bolinas and it was proposed we play. It was that afternoon that my life changed forever, in a fun-game kind of way. Although there are many variations, I’m going to teach you to play the way my friends and I play, so then you’ll know and we can play together because we always need more players; seriously, it’s super hard to get that many people in a room!",
                            EndDatetime = new DateTime(2022, 6, 8, 1, 40, 5, 773, DateTimeKind.Local).AddTicks(421),
                            EventName = "Mafia game7",
                            ImagePath = "http://127.0.0.1:10000/devstoreaccount1/eventsimages/c3cefc9f-ec6d-4d2d-a338-2e82bdaab3f8Wallpaper.jpg?sv=2018-03-28&st=2022-05-15T19%3A08%3A40Z&se=2022-12-24T20%3A08%3A00Z&sr=c&sp=racwdl&sig=lmj94GQWm6FwAD4z0ZmBRQPJYL0g2%2BD%2BAp5zkdw2kiY%3D",
                            IsCancelled = false,
                            IsCreatedFromOriginal = false,
                            LocationID = "1",
                            Rate = 4.5f,
                            StartDatetime = new DateTime(2022, 6, 8, 0, 40, 5, 773, DateTimeKind.Local).AddTicks(417),
                            UserID = "b74ddd14-6340-4840-95c2-db12554843e5",
                            isFinished = true
                        },
                        new
                        {
                            EventId = "8",
                            Description = "When the game is brought up, at least one person recalls playing it, or something similar, when they were young. I assure you the game is not the same as an adult, when personalities and thought processes are, hopefully, more developed. The game itself was allegedly created by Dmitry Davidoff of the Moscow State University Psychology Department as a research project, and then eventually spread to college campuses in Europe and the United States. It had a heyday in the '90s, along with everything else cool in the world. I hadn’t heard of it until one afternoon this past summer while I was hanging out with friends in Bolinas and it was proposed we play. It was that afternoon that my life changed forever, in a fun-game kind of way. Although there are many variations, I’m going to teach you to play the way my friends and I play, so then you’ll know and we can play together because we always need more players; seriously, it’s super hard to get that many people in a room!",
                            EndDatetime = new DateTime(2022, 6, 8, 1, 40, 5, 773, DateTimeKind.Local).AddTicks(429),
                            EventName = "Mafia game8",
                            ImagePath = "http://127.0.0.1:10000/devstoreaccount1/eventsimages/c3cefc9f-ec6d-4d2d-a338-2e82bdaab3f8Wallpaper.jpg?sv=2018-03-28&st=2022-05-15T19%3A08%3A40Z&se=2022-12-24T20%3A08%3A00Z&sr=c&sp=racwdl&sig=lmj94GQWm6FwAD4z0ZmBRQPJYL0g2%2BD%2BAp5zkdw2kiY%3D",
                            IsCancelled = false,
                            IsCreatedFromOriginal = false,
                            LocationID = "1",
                            Rate = 4.5f,
                            StartDatetime = new DateTime(2022, 6, 8, 0, 40, 5, 773, DateTimeKind.Local).AddTicks(426),
                            UserID = "b74ddd14-6340-4840-95c2-db12554843e5",
                            isFinished = true
                        });
                });

            modelBuilder.Entity("Backend.Models.EventParticipantsDB", b =>
                {
                    b.Property<string>("EventParticipantsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EventId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("EventParticipantsId");

                    b.HasIndex("EventId");

                    b.HasIndex("UserId");

                    b.ToTable("EventParticipants");

                    b.HasData(
                        new
                        {
                            EventParticipantsId = "9",
                            EventId = "1",
                            UserId = "c74ddf14-6340-4840-95c2-db12554843e5"
                        },
                        new
                        {
                            EventParticipantsId = "10",
                            EventId = "2",
                            UserId = "c74ddf14-6340-4840-95c2-db12554843e5"
                        },
                        new
                        {
                            EventParticipantsId = "11",
                            EventId = "7",
                            UserId = "c74ddf14-6340-4840-95c2-db12554843e5"
                        },
                        new
                        {
                            EventParticipantsId = "12",
                            EventId = "8",
                            UserId = "c74ddf14-6340-4840-95c2-db12554843e5"
                        });
                });

            modelBuilder.Entity("Backend.Models.FriendInvitationsDB", b =>
                {
                    b.Property<string>("FriendInvitationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AuthorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRejected")
                        .HasColumnType("bit");

                    b.Property<string>("UserReceiverId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FriendInvitationId");

                    b.HasIndex("AuthorId");

                    b.ToTable("FriendInvitations");
                });

            modelBuilder.Entity("Backend.Models.FriendsDB", b =>
                {
                    b.Property<string>("FriendId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserFriendId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("FriendId");

                    b.HasIndex("UserId");

                    b.ToTable("Friends");
                });

            modelBuilder.Entity("Backend.Models.LocationDB", b =>
                {
                    b.Property<string>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            LocationId = "1",
                            Adress = "Vinnytsia Oblast",
                            Latitude = 49.068764999999999,
                            Longitude = 28.802313999999999
                        });
                });

            modelBuilder.Entity("Backend.Models.ReviewsDB", b =>
                {
                    b.Property<string>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AuthorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EventId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.HasKey("ReviewId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("EventId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("Backend.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "b74ddd14-6340-4840-95c2-db12554843e5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e9004be9-0454-4e05-8f95-8396477e9ee9",
                            Email = "volkovskiy4@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "VOLKOVSKIY4@GMAIL.COM",
                            NormalizedUserName = "TEST1",
                            PasswordHash = "AK84aH2cce/x0qnSTmKAV82b/KqucG0LAYbwAYnaw2KQTPEYjdwIa49qHwr0GtGutw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "763a2c77-ee2c-47aa-81d7-cd89a77bf532",
                            TwoFactorEnabled = false,
                            UserName = "Test1"
                        },
                        new
                        {
                            Id = "c74ddf14-6340-4840-95c2-db12554843e5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "680b1a3d-d74a-41bc-9683-3482c7bf2928",
                            Email = "volkovskiy4@gmail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "VOLKOVSKIY4@GMAIL.COM",
                            NormalizedUserName = "TEST2",
                            PasswordHash = "AJfigdPdyLlajFlVcq1tlex3L+UFEsvf8nlY24MvW7IyyT18GISCB14eH+g6Kgo6kg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d1905867-0ed6-4524-bcc8-bdbf0cd765cb",
                            TwoFactorEnabled = false,
                            UserName = "Test2"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Backend.Models.CommentsDB", b =>
                {
                    b.HasOne("Backend.Models.User", "Author")
                        .WithMany("Comments")
                        .HasForeignKey("AuthorId");

                    b.Navigation("Author");
                });

            modelBuilder.Entity("Backend.Models.EventDB", b =>
                {
                    b.HasOne("Backend.Models.LocationDB", "Location")
                        .WithMany("Events")
                        .HasForeignKey("LocationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend.Models.User", "User")
                        .WithMany("Events")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Backend.Models.EventParticipantsDB", b =>
                {
                    b.HasOne("Backend.Models.EventDB", "Event")
                        .WithMany("EventParticipants")
                        .HasForeignKey("EventId");

                    b.HasOne("Backend.Models.User", "User")
                        .WithMany("EventParticipants")
                        .HasForeignKey("UserId");

                    b.Navigation("Event");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Backend.Models.FriendInvitationsDB", b =>
                {
                    b.HasOne("Backend.Models.User", "Author")
                        .WithMany("FriendInvitations")
                        .HasForeignKey("AuthorId");

                    b.Navigation("Author");
                });

            modelBuilder.Entity("Backend.Models.FriendsDB", b =>
                {
                    b.HasOne("Backend.Models.User", "User")
                        .WithMany("Friends")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Backend.Models.ReviewsDB", b =>
                {
                    b.HasOne("Backend.Models.User", "Author")
                        .WithMany("Reviews")
                        .HasForeignKey("AuthorId");

                    b.HasOne("Backend.Models.EventDB", "Event")
                        .WithMany("Reviews")
                        .HasForeignKey("EventId");

                    b.Navigation("Author");

                    b.Navigation("Event");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Backend.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Backend.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Backend.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Backend.Models.EventDB", b =>
                {
                    b.Navigation("EventParticipants");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("Backend.Models.LocationDB", b =>
                {
                    b.Navigation("Events");
                });

            modelBuilder.Entity("Backend.Models.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("EventParticipants");

                    b.Navigation("Events");

                    b.Navigation("FriendInvitations");

                    b.Navigation("Friends");

                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
