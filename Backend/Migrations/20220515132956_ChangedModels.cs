using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class ChangedModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c887196f-4b23-40d0-a57c-df72a74f9c4c", "AD3xRmrq0i7UHdONRSZEQSgqAhWyRlvj6QiJ91cFCELvd5z0vqkJGJgvwV9OcgpIrg==", "a1d90eb2-c1c9-43f4-b045-e83c66f4b22a" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "1",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 15, 21, 29, 56, 124, DateTimeKind.Local).AddTicks(1526), new DateTime(2022, 5, 15, 16, 29, 56, 121, DateTimeKind.Local).AddTicks(8340) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "2",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 15, 21, 29, 56, 124, DateTimeKind.Local).AddTicks(3620), new DateTime(2022, 5, 15, 16, 29, 56, 124, DateTimeKind.Local).AddTicks(3605) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "3",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 15, 21, 29, 56, 124, DateTimeKind.Local).AddTicks(3638), new DateTime(2022, 5, 15, 16, 29, 56, 124, DateTimeKind.Local).AddTicks(3631) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "4",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 15, 21, 29, 56, 124, DateTimeKind.Local).AddTicks(3656), new DateTime(2022, 5, 15, 16, 29, 56, 124, DateTimeKind.Local).AddTicks(3648) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "5",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 15, 21, 29, 56, 124, DateTimeKind.Local).AddTicks(3674), new DateTime(2022, 5, 15, 16, 29, 56, 124, DateTimeKind.Local).AddTicks(3666) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "6",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 15, 21, 29, 56, 124, DateTimeKind.Local).AddTicks(3691), new DateTime(2022, 5, 15, 16, 29, 56, 124, DateTimeKind.Local).AddTicks(3683) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17309440-39b4-4459-8808-cf89988f553f", "AOmmW8gd07mkltsyQRnpYgXOJmxhKvRQd+LagAan5FD7RuOl0e2N8vdvkEY5oyPjJA==", "6afd5c1f-b7ec-4adf-820c-db6195df9583" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "1",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 15, 20, 40, 20, 743, DateTimeKind.Local).AddTicks(3551), new DateTime(2022, 5, 15, 15, 40, 20, 741, DateTimeKind.Local).AddTicks(7201) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "2",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 15, 20, 40, 20, 743, DateTimeKind.Local).AddTicks(4891), new DateTime(2022, 5, 15, 15, 40, 20, 743, DateTimeKind.Local).AddTicks(4879) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "3",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 15, 20, 40, 20, 743, DateTimeKind.Local).AddTicks(4898), new DateTime(2022, 5, 15, 15, 40, 20, 743, DateTimeKind.Local).AddTicks(4896) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "4",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 15, 20, 40, 20, 743, DateTimeKind.Local).AddTicks(4903), new DateTime(2022, 5, 15, 15, 40, 20, 743, DateTimeKind.Local).AddTicks(4901) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "5",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 15, 20, 40, 20, 743, DateTimeKind.Local).AddTicks(4908), new DateTime(2022, 5, 15, 15, 40, 20, 743, DateTimeKind.Local).AddTicks(4906) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "6",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 15, 20, 40, 20, 743, DateTimeKind.Local).AddTicks(4914), new DateTime(2022, 5, 15, 15, 40, 20, 743, DateTimeKind.Local).AddTicks(4912) });
        }
    }
}
