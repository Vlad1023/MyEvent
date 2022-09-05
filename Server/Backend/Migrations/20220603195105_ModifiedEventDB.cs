using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class ModifiedEventDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsCreatedFromOriginal",
                table: "Events",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCreatedFromOriginal",
                table: "Events");

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
    }
}
