using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class SeedingModification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c772fa5e-0c4e-4df0-97e3-6ecc37fa67d3", "ALE5j4rE7vkPjVGq/MlzNUHWyNg3Gm5Cvl8cOgVKYtBCDYIs/gS3sNOLc2hI3ML1Rg==", "bba993b4-7e8d-406c-ae1a-a3e02e31b8b4" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "1",
                columns: new[] { "Description", "EndDatetime", "ImagePath", "StartDatetime" },
                values: new object[] { "When the game is brought up, at least one person recalls playing it, or something similar, when they were young. I assure you the game is not the same as an adult, when personalities and thought processes are, hopefully, more developed. The game itself was allegedly created by Dmitry Davidoff of the Moscow State University Psychology Department as a research project, and then eventually spread to college campuses in Europe and the United States. It had a heyday in the '90s, along with everything else cool in the world. I hadn’t heard of it until one afternoon this past summer while I was hanging out with friends in Bolinas and it was proposed we play. It was that afternoon that my life changed forever, in a fun-game kind of way. Although there are many variations, I’m going to teach you to play the way my friends and I play, so then you’ll know and we can play together because we always need more players; seriously, it’s super hard to get that many people in a room!", new DateTime(2022, 5, 19, 1, 27, 58, 145, DateTimeKind.Local).AddTicks(3684), "http://127.0.0.1:10000/devstoreaccount1/eventsimages/c3cefc9f-ec6d-4d2d-a338-2e82bdaab3f8Wallpaper.jpg?sv=2018-03-28&st=2022-05-15T19%3A08%3A40Z&se=2022-12-24T20%3A08%3A00Z&sr=c&sp=racwdl&sig=lmj94GQWm6FwAD4z0ZmBRQPJYL0g2%2BD%2BAp5zkdw2kiY%3D", new DateTime(2022, 5, 18, 20, 27, 58, 143, DateTimeKind.Local).AddTicks(6732) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "2",
                columns: new[] { "Description", "EndDatetime", "EventName", "ImagePath", "StartDatetime" },
                values: new object[] { "When the game is brought up, at least one person recalls playing it, or something similar, when they were young. I assure you the game is not the same as an adult, when personalities and thought processes are, hopefully, more developed. The game itself was allegedly created by Dmitry Davidoff of the Moscow State University Psychology Department as a research project, and then eventually spread to college campuses in Europe and the United States. It had a heyday in the '90s, along with everything else cool in the world. I hadn’t heard of it until one afternoon this past summer while I was hanging out with friends in Bolinas and it was proposed we play. It was that afternoon that my life changed forever, in a fun-game kind of way. Although there are many variations, I’m going to teach you to play the way my friends and I play, so then you’ll know and we can play together because we always need more players; seriously, it’s super hard to get that many people in a room!", new DateTime(2022, 5, 19, 1, 27, 58, 145, DateTimeKind.Local).AddTicks(5172), "Mafia game2", "http://127.0.0.1:10000/devstoreaccount1/eventsimages/c3cefc9f-ec6d-4d2d-a338-2e82bdaab3f8Wallpaper.jpg?sv=2018-03-28&st=2022-05-15T19%3A08%3A40Z&se=2022-12-24T20%3A08%3A00Z&sr=c&sp=racwdl&sig=lmj94GQWm6FwAD4z0ZmBRQPJYL0g2%2BD%2BAp5zkdw2kiY%3D", new DateTime(2022, 5, 18, 20, 27, 58, 145, DateTimeKind.Local).AddTicks(5160) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "3",
                columns: new[] { "Description", "EndDatetime", "EventName", "ImagePath", "StartDatetime" },
                values: new object[] { "When the game is brought up, at least one person recalls playing it, or something similar, when they were young. I assure you the game is not the same as an adult, when personalities and thought processes are, hopefully, more developed. The game itself was allegedly created by Dmitry Davidoff of the Moscow State University Psychology Department as a research project, and then eventually spread to college campuses in Europe and the United States. It had a heyday in the '90s, along with everything else cool in the world. I hadn’t heard of it until one afternoon this past summer while I was hanging out with friends in Bolinas and it was proposed we play. It was that afternoon that my life changed forever, in a fun-game kind of way. Although there are many variations, I’m going to teach you to play the way my friends and I play, so then you’ll know and we can play together because we always need more players; seriously, it’s super hard to get that many people in a room!", new DateTime(2022, 5, 19, 1, 27, 58, 145, DateTimeKind.Local).AddTicks(5179), "Mafia game3", "http://127.0.0.1:10000/devstoreaccount1/eventsimages/c3cefc9f-ec6d-4d2d-a338-2e82bdaab3f8Wallpaper.jpg?sv=2018-03-28&st=2022-05-15T19%3A08%3A40Z&se=2022-12-24T20%3A08%3A00Z&sr=c&sp=racwdl&sig=lmj94GQWm6FwAD4z0ZmBRQPJYL0g2%2BD%2BAp5zkdw2kiY%3D", new DateTime(2022, 5, 18, 20, 27, 58, 145, DateTimeKind.Local).AddTicks(5177) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "4",
                columns: new[] { "Description", "EndDatetime", "EventName", "ImagePath", "StartDatetime" },
                values: new object[] { "When the game is brought up, at least one person recalls playing it, or something similar, when they were young. I assure you the game is not the same as an adult, when personalities and thought processes are, hopefully, more developed. The game itself was allegedly created by Dmitry Davidoff of the Moscow State University Psychology Department as a research project, and then eventually spread to college campuses in Europe and the United States. It had a heyday in the '90s, along with everything else cool in the world. I hadn’t heard of it until one afternoon this past summer while I was hanging out with friends in Bolinas and it was proposed we play. It was that afternoon that my life changed forever, in a fun-game kind of way. Although there are many variations, I’m going to teach you to play the way my friends and I play, so then you’ll know and we can play together because we always need more players; seriously, it’s super hard to get that many people in a room!", new DateTime(2022, 5, 19, 1, 27, 58, 145, DateTimeKind.Local).AddTicks(5184), "Mafia game4", "http://127.0.0.1:10000/devstoreaccount1/eventsimages/c3cefc9f-ec6d-4d2d-a338-2e82bdaab3f8Wallpaper.jpg?sv=2018-03-28&st=2022-05-15T19%3A08%3A40Z&se=2022-12-24T20%3A08%3A00Z&sr=c&sp=racwdl&sig=lmj94GQWm6FwAD4z0ZmBRQPJYL0g2%2BD%2BAp5zkdw2kiY%3D", new DateTime(2022, 5, 18, 20, 27, 58, 145, DateTimeKind.Local).AddTicks(5181) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "5",
                columns: new[] { "Description", "EndDatetime", "EventName", "ImagePath", "StartDatetime" },
                values: new object[] { "When the game is brought up, at least one person recalls playing it, or something similar, when they were young. I assure you the game is not the same as an adult, when personalities and thought processes are, hopefully, more developed. The game itself was allegedly created by Dmitry Davidoff of the Moscow State University Psychology Department as a research project, and then eventually spread to college campuses in Europe and the United States. It had a heyday in the '90s, along with everything else cool in the world. I hadn’t heard of it until one afternoon this past summer while I was hanging out with friends in Bolinas and it was proposed we play. It was that afternoon that my life changed forever, in a fun-game kind of way. Although there are many variations, I’m going to teach you to play the way my friends and I play, so then you’ll know and we can play together because we always need more players; seriously, it’s super hard to get that many people in a room!", new DateTime(2022, 5, 19, 1, 27, 58, 145, DateTimeKind.Local).AddTicks(5189), "Mafia game5", "http://127.0.0.1:10000/devstoreaccount1/eventsimages/c3cefc9f-ec6d-4d2d-a338-2e82bdaab3f8Wallpaper.jpg?sv=2018-03-28&st=2022-05-15T19%3A08%3A40Z&se=2022-12-24T20%3A08%3A00Z&sr=c&sp=racwdl&sig=lmj94GQWm6FwAD4z0ZmBRQPJYL0g2%2BD%2BAp5zkdw2kiY%3D", new DateTime(2022, 5, 18, 20, 27, 58, 145, DateTimeKind.Local).AddTicks(5186) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "6",
                columns: new[] { "Description", "EndDatetime", "EventName", "ImagePath", "StartDatetime" },
                values: new object[] { "When the game is brought up, at least one person recalls playing it, or something similar, when they were young. I assure you the game is not the same as an adult, when personalities and thought processes are, hopefully, more developed. The game itself was allegedly created by Dmitry Davidoff of the Moscow State University Psychology Department as a research project, and then eventually spread to college campuses in Europe and the United States. It had a heyday in the '90s, along with everything else cool in the world. I hadn’t heard of it until one afternoon this past summer while I was hanging out with friends in Bolinas and it was proposed we play. It was that afternoon that my life changed forever, in a fun-game kind of way. Although there are many variations, I’m going to teach you to play the way my friends and I play, so then you’ll know and we can play together because we always need more players; seriously, it’s super hard to get that many people in a room!", new DateTime(2022, 5, 19, 1, 27, 58, 145, DateTimeKind.Local).AddTicks(5194), "Mafia game6", "http://127.0.0.1:10000/devstoreaccount1/eventsimages/c3cefc9f-ec6d-4d2d-a338-2e82bdaab3f8Wallpaper.jpg?sv=2018-03-28&st=2022-05-15T19%3A08%3A40Z&se=2022-12-24T20%3A08%3A00Z&sr=c&sp=racwdl&sig=lmj94GQWm6FwAD4z0ZmBRQPJYL0g2%2BD%2BAp5zkdw2kiY%3D", new DateTime(2022, 5, 18, 20, 27, 58, 145, DateTimeKind.Local).AddTicks(5192) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: "1",
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 49.839683999999998, 24.029716000000001 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c887196f-4b23-40d0-a57c-df72a74f9c4c", "AD3xRmrq0i7UHdONRSZEQSgqAhWyRlvj6QiJ91cFCELvd5z0vqkJGJgvwV9OcgpIrg==", "a1d90eb2-c1c9-43f4-b045-e83c66f4b22a" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "1",
                columns: new[] { "Description", "EndDatetime", "ImagePath", "StartDatetime" },
                values: new object[] { "Lorema da dasda jdnasjndajnskdjknadjkn asjndakjn djanks djnasd jknanjdandnsajdjn", new DateTime(2022, 5, 15, 21, 29, 56, 124, DateTimeKind.Local).AddTicks(1526), "/test", new DateTime(2022, 5, 15, 16, 29, 56, 121, DateTimeKind.Local).AddTicks(8340) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "2",
                columns: new[] { "Description", "EndDatetime", "EventName", "ImagePath", "StartDatetime" },
                values: new object[] { "Lorema da dasda jdnasjndajnskdjknadjkn asjndakjn djanks djnasd jknanjdandnsajdjn", new DateTime(2022, 5, 15, 21, 29, 56, 124, DateTimeKind.Local).AddTicks(3620), "Mafia game1", "/test", new DateTime(2022, 5, 15, 16, 29, 56, 124, DateTimeKind.Local).AddTicks(3605) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "3",
                columns: new[] { "Description", "EndDatetime", "EventName", "ImagePath", "StartDatetime" },
                values: new object[] { "Lorema da dasda jdnasjndajnskdjknadjkn asjndakjn djanks djnasd jknanjdandnsajdjn", new DateTime(2022, 5, 15, 21, 29, 56, 124, DateTimeKind.Local).AddTicks(3638), "Mafia game2", "/test", new DateTime(2022, 5, 15, 16, 29, 56, 124, DateTimeKind.Local).AddTicks(3631) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "4",
                columns: new[] { "Description", "EndDatetime", "EventName", "ImagePath", "StartDatetime" },
                values: new object[] { "Lorema da dasda jdnasjndajnskdjknadjkn asjndakjn djanks djnasd jknanjdandnsajdjn", new DateTime(2022, 5, 15, 21, 29, 56, 124, DateTimeKind.Local).AddTicks(3656), "Mafia game3", "/test", new DateTime(2022, 5, 15, 16, 29, 56, 124, DateTimeKind.Local).AddTicks(3648) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "5",
                columns: new[] { "Description", "EndDatetime", "EventName", "ImagePath", "StartDatetime" },
                values: new object[] { "Lorema da dasda jdnasjndajnskdjknadjkn asjndakjn djanks djnasd jknanjdandnsajdjn", new DateTime(2022, 5, 15, 21, 29, 56, 124, DateTimeKind.Local).AddTicks(3674), "Mafia game4", "/test", new DateTime(2022, 5, 15, 16, 29, 56, 124, DateTimeKind.Local).AddTicks(3666) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "6",
                columns: new[] { "Description", "EndDatetime", "EventName", "ImagePath", "StartDatetime" },
                values: new object[] { "Lorema da dasda jdnasjndajnskdjknadjkn asjndakjn djanks djnasd jknanjdandnsajdjn", new DateTime(2022, 5, 15, 21, 29, 56, 124, DateTimeKind.Local).AddTicks(3691), "Mafia game5", "/test", new DateTime(2022, 5, 15, 16, 29, 56, 124, DateTimeKind.Local).AddTicks(3683) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: "1",
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 48.733755000000002, 37.586129999999997 });
        }
    }
}
