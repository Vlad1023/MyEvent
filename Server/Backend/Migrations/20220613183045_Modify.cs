using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class Modify : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c13c1ef5-191c-4c30-b807-27707f2e6bad", "AKzPdVBodILqVzNlASHwKRbpVn3uKAfhKaP6S/QPDTiEhzeoqDL+1JhIb1SZknA7+Q==", "38a26594-db01-452c-933a-bc2a5b0b0528" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c74ddf14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cecd2ac0-a518-48ca-a58a-4123c566770f", "ALmHnCVNC/TPiVKk4ipZ7wzEqAJ+TR8j+xcjOxH2pDvEcRUgB/tWkBZIRraZ0w38NQ==", "86730508-9e0f-4d54-946d-19d1def6cdb9" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "1",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 13, 21, 31, 14, 404, DateTimeKind.Local).AddTicks(8285), new DateTime(2022, 6, 13, 21, 30, 44, 402, DateTimeKind.Local).AddTicks(6926) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "2",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 16, 4, 30, 44, 404, DateTimeKind.Local).AddTicks(9851), new DateTime(2022, 6, 15, 3, 30, 44, 404, DateTimeKind.Local).AddTicks(9832) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "3",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 16, 4, 30, 44, 404, DateTimeKind.Local).AddTicks(9858), new DateTime(2022, 6, 15, 3, 30, 44, 404, DateTimeKind.Local).AddTicks(9856) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "4",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 16, 4, 30, 44, 404, DateTimeKind.Local).AddTicks(9864), new DateTime(2022, 6, 15, 3, 30, 44, 404, DateTimeKind.Local).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "5",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 16, 4, 30, 44, 404, DateTimeKind.Local).AddTicks(9869), new DateTime(2022, 6, 15, 3, 30, 44, 404, DateTimeKind.Local).AddTicks(9867) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "6",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 16, 4, 30, 44, 404, DateTimeKind.Local).AddTicks(9874), new DateTime(2022, 6, 15, 3, 30, 44, 404, DateTimeKind.Local).AddTicks(9872) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "7",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 13, 20, 30, 44, 404, DateTimeKind.Local).AddTicks(9879), new DateTime(2022, 6, 13, 19, 30, 44, 404, DateTimeKind.Local).AddTicks(9877) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "8",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 13, 20, 30, 44, 404, DateTimeKind.Local).AddTicks(9885), new DateTime(2022, 6, 13, 19, 30, 44, 404, DateTimeKind.Local).AddTicks(9882) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69618bc4-33e8-4a9a-af3c-46d0ed941975", "ABXXkiYDcYtPkRLCyMzh1i+Aku9b0RPLAWZnt7JVPqwWCqEJI2D3xHuD1DxtA7Qhmw==", "2df55535-968c-49be-b7b5-55e96e6ccd92" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c74ddf14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef1dfda6-5897-4a58-a32b-8d6eb4562467", "ACJEJeTvcAMuEQvm6XyZ13cy3pjVA8Lwerjh+E97uvf4IRaui1VgwKziDgOnH2f59g==", "fb05e59b-7140-4e91-adef-569516899f48" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "1",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 13, 19, 31, 56, 699, DateTimeKind.Local).AddTicks(339), new DateTime(2022, 6, 13, 19, 31, 26, 697, DateTimeKind.Local).AddTicks(3634) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "2",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 16, 2, 31, 26, 699, DateTimeKind.Local).AddTicks(1784), new DateTime(2022, 6, 15, 1, 31, 26, 699, DateTimeKind.Local).AddTicks(1764) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "3",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 16, 2, 31, 26, 699, DateTimeKind.Local).AddTicks(1791), new DateTime(2022, 6, 15, 1, 31, 26, 699, DateTimeKind.Local).AddTicks(1789) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "4",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 16, 2, 31, 26, 699, DateTimeKind.Local).AddTicks(1796), new DateTime(2022, 6, 15, 1, 31, 26, 699, DateTimeKind.Local).AddTicks(1794) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "5",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 16, 2, 31, 26, 699, DateTimeKind.Local).AddTicks(1801), new DateTime(2022, 6, 15, 1, 31, 26, 699, DateTimeKind.Local).AddTicks(1799) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "6",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 16, 2, 31, 26, 699, DateTimeKind.Local).AddTicks(1806), new DateTime(2022, 6, 15, 1, 31, 26, 699, DateTimeKind.Local).AddTicks(1804) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "7",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 13, 18, 31, 26, 699, DateTimeKind.Local).AddTicks(1811), new DateTime(2022, 6, 13, 17, 31, 26, 699, DateTimeKind.Local).AddTicks(1809) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "8",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 13, 18, 31, 26, 699, DateTimeKind.Local).AddTicks(1816), new DateTime(2022, 6, 13, 17, 31, 26, 699, DateTimeKind.Local).AddTicks(1814) });
        }
    }
}
