using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class M : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateAdded",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateAdded",
                table: "Comments");

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
        }
    }
}
