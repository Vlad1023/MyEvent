using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class ChangedSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17309440-39b4-4459-8808-cf89988f553f", "TEST1", "AOmmW8gd07mkltsyQRnpYgXOJmxhKvRQd+LagAan5FD7RuOl0e2N8vdvkEY5oyPjJA==", "6afd5c1f-b7ec-4adf-820c-db6195df9583" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "455c3107-32d5-45f9-8758-8fa1a352a657", null, "AJtQn7aPYwUBreGFV/umrnoWXMChjsvuhUqHRjG19r/ozEfFAYiBolSKk7fU9Rsvnw==", "df8847a5-8842-48cd-8922-f14cb3195600" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "1",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 15, 20, 36, 19, 599, DateTimeKind.Local).AddTicks(5876), new DateTime(2022, 5, 15, 15, 36, 19, 597, DateTimeKind.Local).AddTicks(9134) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "2",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 15, 20, 36, 19, 599, DateTimeKind.Local).AddTicks(7230), new DateTime(2022, 5, 15, 15, 36, 19, 599, DateTimeKind.Local).AddTicks(7218) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "3",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 15, 20, 36, 19, 599, DateTimeKind.Local).AddTicks(7236), new DateTime(2022, 5, 15, 15, 36, 19, 599, DateTimeKind.Local).AddTicks(7234) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "4",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 15, 20, 36, 19, 599, DateTimeKind.Local).AddTicks(7242), new DateTime(2022, 5, 15, 15, 36, 19, 599, DateTimeKind.Local).AddTicks(7240) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "5",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 15, 20, 36, 19, 599, DateTimeKind.Local).AddTicks(7247), new DateTime(2022, 5, 15, 15, 36, 19, 599, DateTimeKind.Local).AddTicks(7245) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "6",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 5, 15, 20, 36, 19, 599, DateTimeKind.Local).AddTicks(7252), new DateTime(2022, 5, 15, 15, 36, 19, 599, DateTimeKind.Local).AddTicks(7250) });
        }
    }
}
