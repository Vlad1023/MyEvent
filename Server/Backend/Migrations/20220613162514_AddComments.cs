using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class AddComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EventId",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8909b3bc-37c5-4493-b1a8-657118a299f7", "AP3oxsVrKFvFI5VpNq8oIXHGcAcI66+prqU9Rujus5waq5Txp7RpkNeqTIj7tcIa5Q==", "a5f3c6b5-f0da-4cd5-8504-30aecd26c760" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c74ddf14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd8b9401-ee9f-4f63-8324-921118956a82", "AAAlUBztYMormKkby77oPJ2xbnIpkCdwMTvCjvbXGOv/ivdig1koOsddWNiYZg+aNQ==", "e59cdf09-42a0-4cc0-bfe2-3a1351758898" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "1",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 13, 19, 25, 43, 954, DateTimeKind.Local).AddTicks(5723), new DateTime(2022, 6, 13, 19, 25, 13, 952, DateTimeKind.Local).AddTicks(9870) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "2",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 16, 2, 25, 13, 954, DateTimeKind.Local).AddTicks(7223), new DateTime(2022, 6, 15, 1, 25, 13, 954, DateTimeKind.Local).AddTicks(7205) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "3",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 16, 2, 25, 13, 954, DateTimeKind.Local).AddTicks(7230), new DateTime(2022, 6, 15, 1, 25, 13, 954, DateTimeKind.Local).AddTicks(7228) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "4",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 16, 2, 25, 13, 954, DateTimeKind.Local).AddTicks(7236), new DateTime(2022, 6, 15, 1, 25, 13, 954, DateTimeKind.Local).AddTicks(7233) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "5",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 16, 2, 25, 13, 954, DateTimeKind.Local).AddTicks(7241), new DateTime(2022, 6, 15, 1, 25, 13, 954, DateTimeKind.Local).AddTicks(7239) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "6",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 16, 2, 25, 13, 954, DateTimeKind.Local).AddTicks(7247), new DateTime(2022, 6, 15, 1, 25, 13, 954, DateTimeKind.Local).AddTicks(7244) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "7",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 13, 18, 25, 13, 954, DateTimeKind.Local).AddTicks(7255), new DateTime(2022, 6, 13, 17, 25, 13, 954, DateTimeKind.Local).AddTicks(7252) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "8",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 13, 18, 25, 13, 954, DateTimeKind.Local).AddTicks(7263), new DateTime(2022, 6, 13, 17, 25, 13, 954, DateTimeKind.Local).AddTicks(7259) });

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Events_CommentId",
                table: "Comments",
                column: "CommentId",
                principalTable: "Events",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Events_CommentId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "Comments");

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
    }
}
