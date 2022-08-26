using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class AddParticipants : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EventParticipantsDBs",
                columns: table => new
                {
                    EventParticipantsId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EventId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventParticipantsDBs", x => x.EventParticipantsId);
                    table.ForeignKey(
                        name: "FK_EventParticipantsDBs_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EventParticipantsDBs_Events_EventId",
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
                values: new object[] { "0328d5dc-1ead-400f-b2c4-7f1089cda22b", "AFo3k/cio1ZY8aQIXA0QrijtttOAeRs76ImnCZj+fQvhmHMRYoBLg6xYlelX2TLM/A==", "db955a0d-974c-4a42-be20-2377707ebb4f" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c74ddf14-6340-4840-95c2-db12554843e5", 0, "7f931dae-ce9a-4afd-a2ad-219edf8f7e6e", "volkovskiy4@gmail.com", false, false, null, "VOLKOVSKIY4@GMAIL.COM", "TEST2", "AJcGxTvxo2ZV+fCaAZWn4rPCwrhMUqyylnO30Vgn9aoOiFqeSJmV9sEJTbju1WEZ7w==", null, false, "28f9cb86-6a76-4d17-b12f-c640875e501f", false, "Test2" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "1",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 22, 1, 45, 12, 13, DateTimeKind.Local).AddTicks(9134), new DateTime(2022, 5, 21, 20, 45, 12, 11, DateTimeKind.Local).AddTicks(4281) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "2",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 22, 1, 45, 12, 14, DateTimeKind.Local).AddTicks(727), new DateTime(2022, 5, 21, 20, 45, 12, 14, DateTimeKind.Local).AddTicks(715) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "3",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 22, 1, 45, 12, 14, DateTimeKind.Local).AddTicks(734), new DateTime(2022, 5, 21, 20, 45, 12, 14, DateTimeKind.Local).AddTicks(731) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "4",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 22, 1, 45, 12, 14, DateTimeKind.Local).AddTicks(739), new DateTime(2022, 5, 21, 20, 45, 12, 14, DateTimeKind.Local).AddTicks(737) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "5",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 22, 1, 45, 12, 14, DateTimeKind.Local).AddTicks(744), new DateTime(2022, 5, 21, 20, 45, 12, 14, DateTimeKind.Local).AddTicks(742) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "6",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 22, 1, 45, 12, 14, DateTimeKind.Local).AddTicks(750), new DateTime(2022, 5, 21, 20, 45, 12, 14, DateTimeKind.Local).AddTicks(747) });

            migrationBuilder.InsertData(
                table: "EventParticipantsDBs",
                columns: new[] { "EventParticipantsId", "EventId", "UserId" },
                values: new object[] { "7", "1", "c74ddf14-6340-4840-95c2-db12554843e5" });

            migrationBuilder.InsertData(
                table: "EventParticipantsDBs",
                columns: new[] { "EventParticipantsId", "EventId", "UserId" },
                values: new object[] { "8", "2", "c74ddf14-6340-4840-95c2-db12554843e5" });

            migrationBuilder.InsertData(
                table: "EventParticipantsDBs",
                columns: new[] { "EventParticipantsId", "EventId", "UserId" },
                values: new object[] { "9", "3", "c74ddf14-6340-4840-95c2-db12554843e5" });

            migrationBuilder.CreateIndex(
                name: "IX_EventParticipantsDBs_EventId",
                table: "EventParticipantsDBs",
                column: "EventId");

            migrationBuilder.CreateIndex(
                name: "IX_EventParticipantsDBs_UserId",
                table: "EventParticipantsDBs",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventParticipantsDBs");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c74ddf14-6340-4840-95c2-db12554843e5");

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
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 19, 1, 27, 58, 145, DateTimeKind.Local).AddTicks(3684), new DateTime(2022, 5, 18, 20, 27, 58, 143, DateTimeKind.Local).AddTicks(6732) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "2",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 19, 1, 27, 58, 145, DateTimeKind.Local).AddTicks(5172), new DateTime(2022, 5, 18, 20, 27, 58, 145, DateTimeKind.Local).AddTicks(5160) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "3",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 19, 1, 27, 58, 145, DateTimeKind.Local).AddTicks(5179), new DateTime(2022, 5, 18, 20, 27, 58, 145, DateTimeKind.Local).AddTicks(5177) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "4",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 19, 1, 27, 58, 145, DateTimeKind.Local).AddTicks(5184), new DateTime(2022, 5, 18, 20, 27, 58, 145, DateTimeKind.Local).AddTicks(5181) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "5",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 19, 1, 27, 58, 145, DateTimeKind.Local).AddTicks(5189), new DateTime(2022, 5, 18, 20, 27, 58, 145, DateTimeKind.Local).AddTicks(5186) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "6",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 19, 1, 27, 58, 145, DateTimeKind.Local).AddTicks(5194), new DateTime(2022, 5, 18, 20, 27, 58, 145, DateTimeKind.Local).AddTicks(5192) });
        }
    }
}
