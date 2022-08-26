using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class ModifyComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Events_CommentId",
                table: "Comments");

            migrationBuilder.AlterColumn<string>(
                name: "EventId",
                table: "Comments",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d6087f9-fdf0-486c-bd6c-4429f3a8b341", "AFXF9nkGWFoSKzoJDkWvEKDhJXzCEcTN5/AblDPtxQfZRE6wNGUjfEkM3TLH600H0g==", "373e99b6-3017-4df3-9b74-696ab786d1c7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c74ddf14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5da4e820-ef2e-4a7b-a251-5ef7fb0ddf45", "AAtPrMILMdS5pnar4y17AcMY4GoULBNeRkEOiMs3/Z83tBLuQ9JO2/SRepjjolJx3Q==", "9425a10a-e005-4eb4-8729-ba579a86aa0c" });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "1",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 13, 21, 32, 53, 20, DateTimeKind.Local).AddTicks(7104), new DateTime(2022, 6, 13, 21, 32, 23, 18, DateTimeKind.Local).AddTicks(5658) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "2",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 16, 4, 32, 23, 20, DateTimeKind.Local).AddTicks(8843), new DateTime(2022, 6, 15, 3, 32, 23, 20, DateTimeKind.Local).AddTicks(8820) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "3",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 16, 4, 32, 23, 20, DateTimeKind.Local).AddTicks(8851), new DateTime(2022, 6, 15, 3, 32, 23, 20, DateTimeKind.Local).AddTicks(8848) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "4",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 16, 4, 32, 23, 20, DateTimeKind.Local).AddTicks(8857), new DateTime(2022, 6, 15, 3, 32, 23, 20, DateTimeKind.Local).AddTicks(8855) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "5",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 16, 4, 32, 23, 20, DateTimeKind.Local).AddTicks(8863), new DateTime(2022, 6, 15, 3, 32, 23, 20, DateTimeKind.Local).AddTicks(8860) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "6",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 16, 4, 32, 23, 20, DateTimeKind.Local).AddTicks(8868), new DateTime(2022, 6, 15, 3, 32, 23, 20, DateTimeKind.Local).AddTicks(8865) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "7",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 13, 20, 32, 23, 20, DateTimeKind.Local).AddTicks(8873), new DateTime(2022, 6, 13, 19, 32, 23, 20, DateTimeKind.Local).AddTicks(8870) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: "8",
                columns: new[] { "EndDatetime", "StartDatetime" },
                values: new object[] { new DateTime(2022, 6, 13, 20, 32, 23, 20, DateTimeKind.Local).AddTicks(8878), new DateTime(2022, 6, 13, 19, 32, 23, 20, DateTimeKind.Local).AddTicks(8876) });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_EventId",
                table: "Comments",
                column: "EventId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Events_EventId",
                table: "Comments",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Events_EventId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_EventId",
                table: "Comments");

            migrationBuilder.AlterColumn<string>(
                name: "EventId",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Events_CommentId",
                table: "Comments",
                column: "CommentId",
                principalTable: "Events",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
