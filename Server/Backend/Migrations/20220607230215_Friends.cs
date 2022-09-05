using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class Friends : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Friend",
                columns: table => new
                {
                    FriendId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserFriendId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Friend", x => x.FriendId);
                });

            migrationBuilder.CreateTable(
                name: "FriendDBUser",
                columns: table => new
                {
                    FriendsFriendId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UsersId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FriendDBUser", x => new { x.FriendsFriendId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_FriendDBUser_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FriendDBUser_Friend_FriendsFriendId",
                        column: x => x.FriendsFriendId,
                        principalTable: "Friend",
                        principalColumn: "FriendId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "492b6437-c83f-4a98-8085-9c40ff6efcc6", "ABWcANjeF8njgxZ48/3kL0/e2rGMhDcpc9DPUGaGuNoQFQPIQZGV3IcSmODfHL+HFg==", "94f366f2-69f6-4cc7-ab15-513c670a323e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c74ddf14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c1b543f0-22c9-454c-8139-e0d219b6b72b", "APjk1z2iS1iSxksqES8MyhXKZEmRMmCkRUo+s/stKVNF/P2gk7QfgfqXQmoqHXi3Hw==", "5e803da7-baba-4dc2-b6c3-a68a4e7a3176" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "1",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 8, 2, 2, 44, 625, DateTimeKind.Local).AddTicks(882), new DateTime(2022, 6, 8, 2, 2, 14, 623, DateTimeKind.Local).AddTicks(3264) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "2",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 10, 9, 2, 14, 625, DateTimeKind.Local).AddTicks(2450), new DateTime(2022, 6, 9, 8, 2, 14, 625, DateTimeKind.Local).AddTicks(2431) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "3",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 10, 9, 2, 14, 625, DateTimeKind.Local).AddTicks(2458), new DateTime(2022, 6, 9, 8, 2, 14, 625, DateTimeKind.Local).AddTicks(2455) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "4",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 10, 9, 2, 14, 625, DateTimeKind.Local).AddTicks(2463), new DateTime(2022, 6, 9, 8, 2, 14, 625, DateTimeKind.Local).AddTicks(2461) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "5",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 10, 9, 2, 14, 625, DateTimeKind.Local).AddTicks(2470), new DateTime(2022, 6, 9, 8, 2, 14, 625, DateTimeKind.Local).AddTicks(2467) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "6",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 10, 9, 2, 14, 625, DateTimeKind.Local).AddTicks(2475), new DateTime(2022, 6, 9, 8, 2, 14, 625, DateTimeKind.Local).AddTicks(2473) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "7",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 8, 1, 2, 14, 625, DateTimeKind.Local).AddTicks(2480), new DateTime(2022, 6, 8, 0, 2, 14, 625, DateTimeKind.Local).AddTicks(2478) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "8",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 8, 1, 2, 14, 625, DateTimeKind.Local).AddTicks(2485), new DateTime(2022, 6, 8, 0, 2, 14, 625, DateTimeKind.Local).AddTicks(2483) });

            migrationBuilder.CreateIndex(
                name: "IX_FriendDBUser_UsersId",
                table: "FriendDBUser",
                column: "UsersId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FriendDBUser");

            migrationBuilder.DropTable(
                name: "Friend");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d578b12-b857-4482-aae6-4feddb227957", "AB0435qHuzrkSvNKxSqC2rxLx0gLqQflkmW3hxZXr5QZiUXyLRVU+N37tnz/H5LCfw==", "036a5e22-147a-4476-aba7-27b252efa9cd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c74ddf14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12207cf2-74f0-472f-8ddf-9894f4543c82", "AHuWVbToMw0CaDaTy+djzh9LPsxoyUAX1lGEZcJ2ZG5+f3eF17PfOI8W79VBBYr2Sw==", "0e7635e9-7b8b-40b8-9565-2c25cb9bccd7" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "1",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 3, 22, 51, 34, 413, DateTimeKind.Local).AddTicks(6180), new DateTime(2022, 6, 3, 22, 51, 4, 411, DateTimeKind.Local).AddTicks(2422) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "2",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 6, 5, 51, 4, 413, DateTimeKind.Local).AddTicks(8161), new DateTime(2022, 6, 5, 4, 51, 4, 413, DateTimeKind.Local).AddTicks(8136) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "3",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 6, 5, 51, 4, 413, DateTimeKind.Local).AddTicks(8171), new DateTime(2022, 6, 5, 4, 51, 4, 413, DateTimeKind.Local).AddTicks(8168) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "4",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 6, 5, 51, 4, 413, DateTimeKind.Local).AddTicks(8178), new DateTime(2022, 6, 5, 4, 51, 4, 413, DateTimeKind.Local).AddTicks(8175) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "5",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 6, 5, 51, 4, 413, DateTimeKind.Local).AddTicks(8187), new DateTime(2022, 6, 5, 4, 51, 4, 413, DateTimeKind.Local).AddTicks(8184) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "6",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 6, 5, 51, 4, 413, DateTimeKind.Local).AddTicks(8194), new DateTime(2022, 6, 5, 4, 51, 4, 413, DateTimeKind.Local).AddTicks(8191) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "7",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 3, 21, 51, 4, 413, DateTimeKind.Local).AddTicks(8200), new DateTime(2022, 6, 3, 20, 51, 4, 413, DateTimeKind.Local).AddTicks(8197) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "8",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 3, 21, 51, 4, 413, DateTimeKind.Local).AddTicks(8207), new DateTime(2022, 6, 3, 20, 51, 4, 413, DateTimeKind.Local).AddTicks(8204) });
        }
    }
}
