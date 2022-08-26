using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class ModifiedEventDBOriginalEvent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OriginalEventId",
                table: "Events",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2be1f221-c00b-404f-a509-543fb7171c71", "AJNvOHgYa7UV+wu/BCOB34bvFKRlN7vzviQpybdjdzFj2gkQ4dKoYIfVyLjw309Jhw==", "80f1aebe-d0f8-40a5-91b4-ac24027a29fc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c74ddf14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3eb48e42-481b-412b-9730-3c15464ecc44", "AGyt0Vx9oqW+W5L04ZK+KUuZ23iRpQE7MnmiPDZVdPhOWFnd1L7Mx8peFHo2qszOeQ==", "bd9e06a6-24db-445e-9b8f-966281a4ca22" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "1",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 12, 15, 51, 39, 963, DateTimeKind.Local).AddTicks(5884), new DateTime(2022, 6, 12, 15, 51, 9, 962, DateTimeKind.Local).AddTicks(322) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "2",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 14, 22, 51, 9, 963, DateTimeKind.Local).AddTicks(7340), new DateTime(2022, 6, 13, 21, 51, 9, 963, DateTimeKind.Local).AddTicks(7319) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "3",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 14, 22, 51, 9, 963, DateTimeKind.Local).AddTicks(7347), new DateTime(2022, 6, 13, 21, 51, 9, 963, DateTimeKind.Local).AddTicks(7344) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "4",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 14, 22, 51, 9, 963, DateTimeKind.Local).AddTicks(7352), new DateTime(2022, 6, 13, 21, 51, 9, 963, DateTimeKind.Local).AddTicks(7350) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "5",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 14, 22, 51, 9, 963, DateTimeKind.Local).AddTicks(7357), new DateTime(2022, 6, 13, 21, 51, 9, 963, DateTimeKind.Local).AddTicks(7355) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "6",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 14, 22, 51, 9, 963, DateTimeKind.Local).AddTicks(7362), new DateTime(2022, 6, 13, 21, 51, 9, 963, DateTimeKind.Local).AddTicks(7360) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "7",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 51, 9, 963, DateTimeKind.Local).AddTicks(7367), new DateTime(2022, 6, 12, 13, 51, 9, 963, DateTimeKind.Local).AddTicks(7365) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "8",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 12, 14, 51, 9, 963, DateTimeKind.Local).AddTicks(7371), new DateTime(2022, 6, 12, 13, 51, 9, 963, DateTimeKind.Local).AddTicks(7369) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OriginalEventId",
                table: "Events");

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
        }
    }
}
