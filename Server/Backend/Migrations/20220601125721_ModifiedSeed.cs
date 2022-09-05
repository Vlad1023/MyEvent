using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class ModifiedSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "addd10ff-2453-447f-8e86-505904da8178", "AFqHLAx41fDinVJcJAGjuxqV48vkxRXZDjUHw+pVzL4iWyScfLZgHy6gJPqVjaIfNg==", "c06976e4-267b-486f-8e1f-6f877e4848fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c74ddf14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ad96251-664a-41a1-aed4-d5213b14e2a8", "AE1C7OwTUMym7sQJlts9T30ztoYe10tBVeT4tzOhxOwOOU0gWldhS1a5Db3j/CJl+w==", "1eb3b12a-d05c-4fa5-8757-ebb18f132cae" });

            migrationBuilder.UpdateData(
                table: "EventParticipants",
                keyColumn: "EventParticipantsId",
                keyValue: "11",
                column: "EventId",
                value: "7");

            migrationBuilder.UpdateData(
                table: "EventParticipants",
                keyColumn: "EventParticipantsId",
                keyValue: "12",
                column: "UserId",
                value: "c74ddf14-6340-4840-95c2-db12554843e5");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "1",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 57, 20, 443, DateTimeKind.Local).AddTicks(5885), new DateTime(2022, 6, 1, 18, 57, 20, 441, DateTimeKind.Local).AddTicks(9511) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "2",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 57, 20, 443, DateTimeKind.Local).AddTicks(7451), new DateTime(2022, 6, 1, 18, 57, 20, 443, DateTimeKind.Local).AddTicks(7440) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "3",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 57, 20, 443, DateTimeKind.Local).AddTicks(7459), new DateTime(2022, 6, 1, 18, 57, 20, 443, DateTimeKind.Local).AddTicks(7456) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "4",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 57, 20, 443, DateTimeKind.Local).AddTicks(7464), new DateTime(2022, 6, 1, 18, 57, 20, 443, DateTimeKind.Local).AddTicks(7462) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "5",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 57, 20, 443, DateTimeKind.Local).AddTicks(7469), new DateTime(2022, 6, 1, 18, 57, 20, 443, DateTimeKind.Local).AddTicks(7467) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "6",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 1, 20, 57, 20, 443, DateTimeKind.Local).AddTicks(7474), new DateTime(2022, 6, 1, 18, 57, 20, 443, DateTimeKind.Local).AddTicks(7472) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "7",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 1, 14, 57, 20, 443, DateTimeKind.Local).AddTicks(7479), new DateTime(2022, 6, 1, 13, 57, 20, 443, DateTimeKind.Local).AddTicks(7477) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "8",
                columns: new[] { "EndDatetime", "StartDatetime", "UserID" },
                values: new object[] { new DateTime(2022, 6, 1, 14, 57, 20, 443, DateTimeKind.Local).AddTicks(7484), new DateTime(2022, 6, 1, 13, 57, 20, 443, DateTimeKind.Local).AddTicks(7482), "b74ddd14-6340-4840-95c2-db12554843e5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "06a4fcf6-527d-408a-9885-0e6f2ec90a9e", "ADKsVUNcU7M5jIenruTMQwWhZsD9Y120UarEkW3IxPbGtVMi9k8qd2oo37EiLxUmmQ==", "73ab224b-b4cb-4879-bfda-9be93cc0104d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c74ddf14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce35643e-5d95-4690-8118-aa0fa3174fb5", "AFXtorC5N+gPZ+10/8xU9Zzh+IIgZ7EcRyAmmIsqCZjEMzMyl8SjB9JWKLREXn77Ew==", "79e2325f-c0c4-42d7-833c-8b79d5d7c1f2" });

            migrationBuilder.UpdateData(
                table: "EventParticipants",
                keyColumn: "EventParticipantsId",
                keyValue: "11",
                column: "EventId",
                value: "3");

            migrationBuilder.UpdateData(
                table: "EventParticipants",
                keyColumn: "EventParticipantsId",
                keyValue: "12",
                column: "UserId",
                value: "b74ddd14-6340-4840-95c2-db12554843e5");

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "1",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 1, 1, 26, 29, 928, DateTimeKind.Local).AddTicks(7918), new DateTime(2022, 5, 31, 23, 26, 29, 927, DateTimeKind.Local).AddTicks(1653) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "2",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 1, 1, 26, 29, 928, DateTimeKind.Local).AddTicks(9404), new DateTime(2022, 5, 31, 23, 26, 29, 928, DateTimeKind.Local).AddTicks(9392) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "3",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 1, 1, 26, 29, 928, DateTimeKind.Local).AddTicks(9411), new DateTime(2022, 5, 31, 23, 26, 29, 928, DateTimeKind.Local).AddTicks(9408) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "4",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 1, 1, 26, 29, 928, DateTimeKind.Local).AddTicks(9416), new DateTime(2022, 5, 31, 23, 26, 29, 928, DateTimeKind.Local).AddTicks(9414) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "5",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 1, 1, 26, 29, 928, DateTimeKind.Local).AddTicks(9421), new DateTime(2022, 5, 31, 23, 26, 29, 928, DateTimeKind.Local).AddTicks(9419) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "6",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 1, 1, 26, 29, 928, DateTimeKind.Local).AddTicks(9426), new DateTime(2022, 5, 31, 23, 26, 29, 928, DateTimeKind.Local).AddTicks(9424) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "7",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 31, 19, 26, 29, 928, DateTimeKind.Local).AddTicks(9431), new DateTime(2022, 5, 31, 18, 26, 29, 928, DateTimeKind.Local).AddTicks(9429) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "8",
                columns: new[] { "EndDatetime", "StartDatetime", "UserID" },
                values: new object[] { new DateTime(2022, 5, 31, 19, 26, 29, 928, DateTimeKind.Local).AddTicks(9436), new DateTime(2022, 5, 31, 18, 26, 29, 928, DateTimeKind.Local).AddTicks(9434), "c74ddf14-6340-4840-95c2-db12554843e5" });
        }
    }
}
