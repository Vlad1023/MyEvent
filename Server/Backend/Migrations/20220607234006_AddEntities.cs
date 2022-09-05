using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class AddEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FriendDBUser");

            migrationBuilder.DropTable(
                name: "Friend");

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FriendInvitations",
                columns: table => new
                {
                    FriendInvitationId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AuthorId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UserReceiverId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    IsRejected = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FriendInvitations", x => x.FriendInvitationId);
                    table.ForeignKey(
                        name: "FK_FriendInvitations_AspNetUsers_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Friends",
                columns: table => new
                {
                    FriendId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UserFriendId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Friends", x => x.FriendId);
                    table.ForeignKey(
                        name: "FK_Friends_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Rate = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    EventId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Reviews_AspNetUsers_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reviews_Events_EventId",
                        column: x => x.EventId,
                        principalTable: "Events",
                        principalColumn: "EventId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e9004be9-0454-4e05-8f95-8396477e9ee9", "AK84aH2cce/x0qnSTmKAV82b/KqucG0LAYbwAYnaw2KQTPEYjdwIa49qHwr0GtGutw==", "763a2c77-ee2c-47aa-81d7-cd89a77bf532" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c74ddf14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "680b1a3d-d74a-41bc-9683-3482c7bf2928", "AJfigdPdyLlajFlVcq1tlex3L+UFEsvf8nlY24MvW7IyyT18GISCB14eH+g6Kgo6kg==", "d1905867-0ed6-4524-bcc8-bdbf0cd765cb" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "1",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 8, 2, 40, 35, 772, DateTimeKind.Local).AddTicks(8235), new DateTime(2022, 6, 8, 2, 40, 5, 770, DateTimeKind.Local).AddTicks(1175) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "2",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 10, 9, 40, 5, 773, DateTimeKind.Local).AddTicks(375), new DateTime(2022, 6, 9, 8, 40, 5, 773, DateTimeKind.Local).AddTicks(349) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "3",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 10, 9, 40, 5, 773, DateTimeKind.Local).AddTicks(385), new DateTime(2022, 6, 9, 8, 40, 5, 773, DateTimeKind.Local).AddTicks(381) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "4",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 10, 9, 40, 5, 773, DateTimeKind.Local).AddTicks(393), new DateTime(2022, 6, 9, 8, 40, 5, 773, DateTimeKind.Local).AddTicks(390) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "5",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 10, 9, 40, 5, 773, DateTimeKind.Local).AddTicks(401), new DateTime(2022, 6, 9, 8, 40, 5, 773, DateTimeKind.Local).AddTicks(398) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "6",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 10, 9, 40, 5, 773, DateTimeKind.Local).AddTicks(410), new DateTime(2022, 6, 9, 8, 40, 5, 773, DateTimeKind.Local).AddTicks(405) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "7",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 8, 1, 40, 5, 773, DateTimeKind.Local).AddTicks(421), new DateTime(2022, 6, 8, 0, 40, 5, 773, DateTimeKind.Local).AddTicks(417) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "8",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 8, 1, 40, 5, 773, DateTimeKind.Local).AddTicks(429), new DateTime(2022, 6, 8, 0, 40, 5, 773, DateTimeKind.Local).AddTicks(426) });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_AuthorId",
                table: "Comments",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_FriendInvitations_AuthorId",
                table: "FriendInvitations",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Friends_UserId",
                table: "Friends",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_AuthorId",
                table: "Reviews",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_EventId",
                table: "Reviews",
                column: "EventId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "FriendInvitations");

            migrationBuilder.DropTable(
                name: "Friends");

            migrationBuilder.DropTable(
                name: "Reviews");

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
    }
}
