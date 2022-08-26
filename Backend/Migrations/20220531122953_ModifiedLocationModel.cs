using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class ModifiedLocationModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Adress",
                table: "Locations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: "1",
                columns: new[] { "Adress", "Latitude", "Longitude" },
                values: new object[] { "Vinnytsia Oblast", 49.068764999999999, 28.802313999999999 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adress",
                table: "Locations");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "856f1009-c761-4b16-b4ca-e9724e9df542", "ANIdTMX+sRcXTAioa1GqZHQHIlwjPSa/X3jCgSCQFuv4h3wCaixuVVo3q0ueCkj8LQ==", "bb9e6980-56da-4d54-a963-0a775262dbbd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c74ddf14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5e1f105-a742-4a08-afe3-212cb1564fab", "AB3/p8UQrYSn6F0S3q5mr3+zWGTLI0atOAc2rOqaCXeUJw0pmV9ukX2RatjJokP9QQ==", "73f6653d-4a59-4de2-9da0-5acc3afacd28" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "1",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 30, 22, 4, 3, 430, DateTimeKind.Local).AddTicks(8011), new DateTime(2022, 5, 30, 17, 4, 3, 429, DateTimeKind.Local).AddTicks(1332) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "2",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 30, 22, 4, 3, 430, DateTimeKind.Local).AddTicks(9494), new DateTime(2022, 5, 30, 17, 4, 3, 430, DateTimeKind.Local).AddTicks(9481) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "3",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 30, 22, 4, 3, 430, DateTimeKind.Local).AddTicks(9501), new DateTime(2022, 5, 30, 17, 4, 3, 430, DateTimeKind.Local).AddTicks(9498) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "4",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 30, 22, 4, 3, 430, DateTimeKind.Local).AddTicks(9506), new DateTime(2022, 5, 30, 17, 4, 3, 430, DateTimeKind.Local).AddTicks(9504) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "5",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 30, 22, 4, 3, 430, DateTimeKind.Local).AddTicks(9511), new DateTime(2022, 5, 30, 17, 4, 3, 430, DateTimeKind.Local).AddTicks(9509) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "6",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 30, 22, 4, 3, 430, DateTimeKind.Local).AddTicks(9517), new DateTime(2022, 5, 30, 17, 4, 3, 430, DateTimeKind.Local).AddTicks(9514) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "7",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 30, 22, 4, 3, 430, DateTimeKind.Local).AddTicks(9521), new DateTime(2022, 5, 30, 17, 4, 3, 430, DateTimeKind.Local).AddTicks(9519) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "8",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 30, 22, 4, 3, 430, DateTimeKind.Local).AddTicks(9526), new DateTime(2022, 5, 30, 17, 4, 3, 430, DateTimeKind.Local).AddTicks(9524) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "LocationId",
                keyValue: "1",
                columns: new[] { "Latitude", "Longitude" },
                values: new object[] { 49.839683999999998, 24.029716000000001 });
        }
    }
}
