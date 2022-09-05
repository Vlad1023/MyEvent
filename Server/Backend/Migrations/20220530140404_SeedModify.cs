using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class SeedModify : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "EventParticipantsId",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "EventParticipantsId",
                keyValue: "8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "856f1009-c761-4b16-b4ca-e9724e9df542", "ANIdTMX+sRcXTAioa1GqZHQHIlwjPSa/X3jCgSCQFuv4h3wCaixuVVo3q0ueCkj8LQ==", "bb9e6980-56da-4d54-a963-0a775262dbbd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c74ddf14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5e1f105-a742-4a08-afe3-212cb1564fab", "AB3/p8UQrYSn6F0S3q5mr3+zWGTLI0atOAc2rOqaCXeUJw0pmV9ukX2RatjJokP9QQ==", "73f6653d-4a59-4de2-9da0-5acc3afacd28" });

            migrationBuilder.UpdateData(
                table: "EventParticipants",
                keyColumn: "EventParticipantsId",
                keyValue: "9",
                column: "EventId",
                value: "1");

            migrationBuilder.InsertData(
                table: "EventParticipants",
                columns: new[] { "EventParticipantsId", "EventId", "UserId" },
                values: new object[,]
                {
                    { "10", "2", "c74ddf14-6340-4840-95c2-db12554843e5" },
                    { "11", "3", "c74ddf14-6340-4840-95c2-db12554843e5" }
                });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "1",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 30, 22, 4, 3, 430, DateTimeKind.Local).AddTicks(8011), new DateTime(2022, 5, 30, 17, 4, 3, 429, DateTimeKind.Local).AddTicks(1332) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "2",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 30, 22, 4, 3, 430, DateTimeKind.Local).AddTicks(9494), new DateTime(2022, 5, 30, 17, 4, 3, 430, DateTimeKind.Local).AddTicks(9481) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "3",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 30, 22, 4, 3, 430, DateTimeKind.Local).AddTicks(9501), new DateTime(2022, 5, 30, 17, 4, 3, 430, DateTimeKind.Local).AddTicks(9498) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "4",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 30, 22, 4, 3, 430, DateTimeKind.Local).AddTicks(9506), new DateTime(2022, 5, 30, 17, 4, 3, 430, DateTimeKind.Local).AddTicks(9504) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "5",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 30, 22, 4, 3, 430, DateTimeKind.Local).AddTicks(9511), new DateTime(2022, 5, 30, 17, 4, 3, 430, DateTimeKind.Local).AddTicks(9509) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "6",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 30, 22, 4, 3, 430, DateTimeKind.Local).AddTicks(9517), new DateTime(2022, 5, 30, 17, 4, 3, 430, DateTimeKind.Local).AddTicks(9514) });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventId", "Description", "EndDatetime", "EventName", "ImagePath", "IsCancelled", "LocationID", "Rate", "StartDatetime", "UserID", "isFinished" },
                values: new object[,]
                {
                    { "7", "When the game is brought up, at least one person recalls playing it, or something similar, when they were young. I assure you the game is not the same as an adult, when personalities and thought processes are, hopefully, more developed. The game itself was allegedly created by Dmitry Davidoff of the Moscow State University Psychology Department as a research project, and then eventually spread to college campuses in Europe and the United States. It had a heyday in the '90s, along with everything else cool in the world. I hadn’t heard of it until one afternoon this past summer while I was hanging out with friends in Bolinas and it was proposed we play. It was that afternoon that my life changed forever, in a fun-game kind of way. Although there are many variations, I’m going to teach you to play the way my friends and I play, so then you’ll know and we can play together because we always need more players; seriously, it’s super hard to get that many people in a room!", new DateTime(2022, 5, 30, 22, 4, 3, 430, DateTimeKind.Local).AddTicks(9521), "Mafia game7", "http://127.0.0.1:10000/devstoreaccount1/eventsimages/c3cefc9f-ec6d-4d2d-a338-2e82bdaab3f8Wallpaper.jpg?sv=2018-03-28&st=2022-05-15T19%3A08%3A40Z&se=2022-12-24T20%3A08%3A00Z&sr=c&sp=racwdl&sig=lmj94GQWm6FwAD4z0ZmBRQPJYL0g2%2BD%2BAp5zkdw2kiY%3D", false, "1", 4.5f, new DateTime(2022, 5, 30, 17, 4, 3, 430, DateTimeKind.Local).AddTicks(9519), "b74ddd14-6340-4840-95c2-db12554843e5", true },
                    { "8", "When the game is brought up, at least one person recalls playing it, or something similar, when they were young. I assure you the game is not the same as an adult, when personalities and thought processes are, hopefully, more developed. The game itself was allegedly created by Dmitry Davidoff of the Moscow State University Psychology Department as a research project, and then eventually spread to college campuses in Europe and the United States. It had a heyday in the '90s, along with everything else cool in the world. I hadn’t heard of it until one afternoon this past summer while I was hanging out with friends in Bolinas and it was proposed we play. It was that afternoon that my life changed forever, in a fun-game kind of way. Although there are many variations, I’m going to teach you to play the way my friends and I play, so then you’ll know and we can play together because we always need more players; seriously, it’s super hard to get that many people in a room!", new DateTime(2022, 5, 30, 22, 4, 3, 430, DateTimeKind.Local).AddTicks(9526), "Mafia game8", "http://127.0.0.1:10000/devstoreaccount1/eventsimages/c3cefc9f-ec6d-4d2d-a338-2e82bdaab3f8Wallpaper.jpg?sv=2018-03-28&st=2022-05-15T19%3A08%3A40Z&se=2022-12-24T20%3A08%3A00Z&sr=c&sp=racwdl&sig=lmj94GQWm6FwAD4z0ZmBRQPJYL0g2%2BD%2BAp5zkdw2kiY%3D", false, "1", 4.5f, new DateTime(2022, 5, 30, 17, 4, 3, 430, DateTimeKind.Local).AddTicks(9524), "c74ddf14-6340-4840-95c2-db12554843e5", true }
                });

            migrationBuilder.InsertData(
                table: "EventParticipants",
                columns: new[] { "EventParticipantsId", "EventId", "UserId" },
                values: new object[] { "12", "8", "b74ddd14-6340-4840-95c2-db12554843e5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "EventParticipantsId",
                keyValue: "10");

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "EventParticipantsId",
                keyValue: "11");

            migrationBuilder.DeleteData(
                table: "EventParticipants",
                keyColumn: "EventParticipantsId",
                keyValue: "12");

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7b3016c-3510-4047-a41f-0abb7034c7d7", "AFXT6Ij2e1rP2IsCNIMHsUDM/89BSXs9LvS1SMBObqadTUBWj0IQdmlDMaHRXDVFlg==", "2dd36c36-728e-419d-bf41-85d3022ce01f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c74ddf14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8bca1298-5451-417f-9ef4-4becb981dcf9", "AKwJAW/nREbK0HlLgYUajBgPifFXatv1yXqmRnrAAY2knvchjW9n5bs4ZV3ck8DDzA==", "b7c8ec0e-4ccb-409a-8b4c-3e343f2d1c08" });

            migrationBuilder.UpdateData(
                table: "EventParticipants",
                keyColumn: "EventParticipantsId",
                keyValue: "9",
                column: "EventId",
                value: "3");

            migrationBuilder.InsertData(
                table: "EventParticipants",
                columns: new[] { "EventParticipantsId", "EventId", "UserId" },
                values: new object[,]
                {
                    { "7", "1", "c74ddf14-6340-4840-95c2-db12554843e5" },
                    { "8", "2", "c74ddf14-6340-4840-95c2-db12554843e5" }
                });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "1",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 22, 1, 47, 6, 687, DateTimeKind.Local).AddTicks(8946), new DateTime(2022, 5, 21, 20, 47, 6, 686, DateTimeKind.Local).AddTicks(3298) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "2",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 22, 1, 47, 6, 688, DateTimeKind.Local).AddTicks(418), new DateTime(2022, 5, 21, 20, 47, 6, 688, DateTimeKind.Local).AddTicks(406) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "3",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 22, 1, 47, 6, 688, DateTimeKind.Local).AddTicks(425), new DateTime(2022, 5, 21, 20, 47, 6, 688, DateTimeKind.Local).AddTicks(423) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "4",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 22, 1, 47, 6, 688, DateTimeKind.Local).AddTicks(430), new DateTime(2022, 5, 21, 20, 47, 6, 688, DateTimeKind.Local).AddTicks(428) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "5",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 22, 1, 47, 6, 688, DateTimeKind.Local).AddTicks(436), new DateTime(2022, 5, 21, 20, 47, 6, 688, DateTimeKind.Local).AddTicks(434) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "6",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 22, 1, 47, 6, 688, DateTimeKind.Local).AddTicks(441), new DateTime(2022, 5, 21, 20, 47, 6, 688, DateTimeKind.Local).AddTicks(439) });
        }
    }
}
