using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class ChangedOneEventDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d75f153b-6356-4699-afe2-5f0ca5f57764", "ALO8VlYdAdZsi1iWIiAd1PFgiEGDp5LaEknc7R9srLHtJHPjR4VoGm9VbTyzqrUk8w==", "429195d1-e8e3-41e9-a24c-bf01ea1cc601" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c74ddf14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35a7744c-e006-4512-a955-fe67c2e6497d", "AD3/eksA1plVMTVmPmQE195qicNJ6+85ShBxS79LCc+eyXPuRTMOG9CijZ3LEptWCQ==", "32e6c726-56a7-4dbe-84cf-429e3f7c14f3" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "1",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 2, 22, 54, 39, 841, DateTimeKind.Local).AddTicks(6773), new DateTime(2022, 6, 2, 22, 54, 9, 840, DateTimeKind.Local).AddTicks(216) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "2",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 5, 5, 54, 9, 841, DateTimeKind.Local).AddTicks(8261), new DateTime(2022, 6, 4, 4, 54, 9, 841, DateTimeKind.Local).AddTicks(8243) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "3",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 5, 5, 54, 9, 841, DateTimeKind.Local).AddTicks(8268), new DateTime(2022, 6, 4, 4, 54, 9, 841, DateTimeKind.Local).AddTicks(8265) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "4",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 5, 5, 54, 9, 841, DateTimeKind.Local).AddTicks(8273), new DateTime(2022, 6, 4, 4, 54, 9, 841, DateTimeKind.Local).AddTicks(8271) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "5",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 5, 5, 54, 9, 841, DateTimeKind.Local).AddTicks(8279), new DateTime(2022, 6, 4, 4, 54, 9, 841, DateTimeKind.Local).AddTicks(8277) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "6",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 5, 5, 54, 9, 841, DateTimeKind.Local).AddTicks(8284), new DateTime(2022, 6, 4, 4, 54, 9, 841, DateTimeKind.Local).AddTicks(8282) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "7",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 2, 21, 54, 9, 841, DateTimeKind.Local).AddTicks(8289), new DateTime(2022, 6, 2, 20, 54, 9, 841, DateTimeKind.Local).AddTicks(8287) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "8",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 2, 21, 54, 9, 841, DateTimeKind.Local).AddTicks(8294), new DateTime(2022, 6, 2, 20, 54, 9, 841, DateTimeKind.Local).AddTicks(8292) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 1, 14, 57, 20, 443, DateTimeKind.Local).AddTicks(7484), new DateTime(2022, 6, 1, 13, 57, 20, 443, DateTimeKind.Local).AddTicks(7482) });
        }
    }
}
