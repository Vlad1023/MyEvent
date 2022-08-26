using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class ModifiedFinishedEvents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 31, 19, 26, 29, 928, DateTimeKind.Local).AddTicks(9436), new DateTime(2022, 5, 31, 18, 26, 29, 928, DateTimeKind.Local).AddTicks(9434) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "911a7ead-3cc9-4c97-be02-22416611faae", "ABW+lyFyW6wuYgS43O2gO0w3uTIkfo8fA7A4EG0bi0OLStP5W22dTsH6jTQjuYKYNw==", "b751762c-6f4c-4824-b0f6-08a882f5d17f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c74ddf14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1431996-5b14-4189-804b-717d8e7a9179", "AHa6M9quqzaeSme1BDt6piYH5aDLahs71ZQMzMhLrJMQYgiUDO/1CXyffxMFKJBxRQ==", "df6cec85-4829-4f5f-9372-17182b7a49c5" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "1",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 31, 20, 29, 53, 198, DateTimeKind.Local).AddTicks(4882), new DateTime(2022, 5, 31, 15, 29, 53, 196, DateTimeKind.Local).AddTicks(7228) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "2",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 31, 20, 29, 53, 198, DateTimeKind.Local).AddTicks(6435), new DateTime(2022, 5, 31, 15, 29, 53, 198, DateTimeKind.Local).AddTicks(6423) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "3",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 31, 20, 29, 53, 198, DateTimeKind.Local).AddTicks(6494), new DateTime(2022, 5, 31, 15, 29, 53, 198, DateTimeKind.Local).AddTicks(6491) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "4",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 31, 20, 29, 53, 198, DateTimeKind.Local).AddTicks(6501), new DateTime(2022, 5, 31, 15, 29, 53, 198, DateTimeKind.Local).AddTicks(6498) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "5",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 31, 20, 29, 53, 198, DateTimeKind.Local).AddTicks(6506), new DateTime(2022, 5, 31, 15, 29, 53, 198, DateTimeKind.Local).AddTicks(6504) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "6",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 31, 20, 29, 53, 198, DateTimeKind.Local).AddTicks(6513), new DateTime(2022, 5, 31, 15, 29, 53, 198, DateTimeKind.Local).AddTicks(6510) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "7",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 31, 20, 29, 53, 198, DateTimeKind.Local).AddTicks(6518), new DateTime(2022, 5, 31, 15, 29, 53, 198, DateTimeKind.Local).AddTicks(6516) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "8",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 31, 20, 29, 53, 198, DateTimeKind.Local).AddTicks(6523), new DateTime(2022, 5, 31, 15, 29, 53, 198, DateTimeKind.Local).AddTicks(6521) });
        }
    }
}
