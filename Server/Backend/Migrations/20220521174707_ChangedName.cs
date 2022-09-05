using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class ChangedName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventParticipantsDBs_AspNetUsers_UserId",
                table: "EventParticipantsDBs");

            migrationBuilder.DropForeignKey(
                name: "FK_EventParticipantsDBs_Events_EventId",
                table: "EventParticipantsDBs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EventParticipantsDBs",
                table: "EventParticipantsDBs");

            migrationBuilder.RenameTable(
                name: "EventParticipantsDBs",
                newName: "EventParticipants");

            migrationBuilder.RenameIndex(
                name: "IX_EventParticipantsDBs_UserId",
                table: "EventParticipants",
                newName: "IX_EventParticipants_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_EventParticipantsDBs_EventId",
                table: "EventParticipants",
                newName: "IX_EventParticipants_EventId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EventParticipants",
                table: "EventParticipants",
                column: "EventParticipantsId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_EventParticipants_AspNetUsers_UserId",
                table: "EventParticipants",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EventParticipants_Events_EventId",
                table: "EventParticipants",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventParticipants_AspNetUsers_UserId",
                table: "EventParticipants");

            migrationBuilder.DropForeignKey(
                name: "FK_EventParticipants_Events_EventId",
                table: "EventParticipants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EventParticipants",
                table: "EventParticipants");

            migrationBuilder.RenameTable(
                name: "EventParticipants",
                newName: "EventParticipantsDBs");

            migrationBuilder.RenameIndex(
                name: "IX_EventParticipants_UserId",
                table: "EventParticipantsDBs",
                newName: "IX_EventParticipantsDBs_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_EventParticipants_EventId",
                table: "EventParticipantsDBs",
                newName: "IX_EventParticipantsDBs_EventId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EventParticipantsDBs",
                table: "EventParticipantsDBs",
                column: "EventParticipantsId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0328d5dc-1ead-400f-b2c4-7f1089cda22b", "AFo3k/cio1ZY8aQIXA0QrijtttOAeRs76ImnCZj+fQvhmHMRYoBLg6xYlelX2TLM/A==", "db955a0d-974c-4a42-be20-2377707ebb4f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c74ddf14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f931dae-ce9a-4afd-a2ad-219edf8f7e6e", "AJcGxTvxo2ZV+fCaAZWn4rPCwrhMUqyylnO30Vgn9aoOiFqeSJmV9sEJTbju1WEZ7w==", "28f9cb86-6a76-4d17-b12f-c640875e501f" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_EventParticipantsDBs_AspNetUsers_UserId",
                table: "EventParticipantsDBs",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EventParticipantsDBs_Events_EventId",
                table: "EventParticipantsDBs",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
