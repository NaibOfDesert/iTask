using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iTask.Migrations
{
    /// <inheritdoc />
    public partial class ProjectDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2024, 11, 11, 23, 57, 18, 83, DateTimeKind.Local).AddTicks(1230), new DateTime(2024, 11, 4, 23, 57, 18, 83, DateTimeKind.Local).AddTicks(1230) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2024, 11, 11, 23, 57, 18, 83, DateTimeKind.Local).AddTicks(1230), new DateTime(2024, 11, 4, 23, 57, 18, 83, DateTimeKind.Local).AddTicks(1230) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2024, 11, 11, 23, 57, 18, 83, DateTimeKind.Local).AddTicks(1230), new DateTime(2024, 11, 4, 23, 57, 18, 83, DateTimeKind.Local).AddTicks(1230) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart", "Description" },
                values: new object[] { new DateTime(2024, 11, 24, 23, 57, 18, 83, DateTimeKind.Local).AddTicks(1150), new DateTime(2024, 11, 4, 23, 57, 18, 83, DateTimeKind.Local).AddTicks(1110), null });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart", "Description" },
                values: new object[] { new DateTime(2024, 11, 24, 23, 57, 18, 83, DateTimeKind.Local).AddTicks(1160), new DateTime(2024, 11, 4, 23, 57, 18, 83, DateTimeKind.Local).AddTicks(1160), null });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateEnd", "DateStart", "Description" },
                values: new object[] { new DateTime(2024, 11, 24, 23, 57, 18, 83, DateTimeKind.Local).AddTicks(1160), new DateTime(2024, 11, 4, 23, 57, 18, 83, DateTimeKind.Local).AddTicks(1160), null });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateEnd", "DateStart", "Description" },
                values: new object[] { new DateTime(2024, 11, 24, 23, 57, 18, 83, DateTimeKind.Local).AddTicks(1160), new DateTime(2024, 11, 4, 23, 57, 18, 83, DateTimeKind.Local).AddTicks(1160), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Projects");

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2024, 10, 29, 21, 1, 16, 924, DateTimeKind.Local).AddTicks(390), new DateTime(2024, 10, 22, 21, 1, 16, 924, DateTimeKind.Local).AddTicks(380) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2024, 10, 29, 21, 1, 16, 924, DateTimeKind.Local).AddTicks(390), new DateTime(2024, 10, 22, 21, 1, 16, 924, DateTimeKind.Local).AddTicks(390) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2024, 10, 29, 21, 1, 16, 924, DateTimeKind.Local).AddTicks(390), new DateTime(2024, 10, 22, 21, 1, 16, 924, DateTimeKind.Local).AddTicks(390) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2024, 11, 11, 21, 1, 16, 924, DateTimeKind.Local).AddTicks(300), new DateTime(2024, 10, 22, 21, 1, 16, 924, DateTimeKind.Local).AddTicks(240) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2024, 11, 11, 21, 1, 16, 924, DateTimeKind.Local).AddTicks(310), new DateTime(2024, 10, 22, 21, 1, 16, 924, DateTimeKind.Local).AddTicks(310) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2024, 11, 11, 21, 1, 16, 924, DateTimeKind.Local).AddTicks(320), new DateTime(2024, 10, 22, 21, 1, 16, 924, DateTimeKind.Local).AddTicks(320) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2024, 11, 11, 21, 1, 16, 924, DateTimeKind.Local).AddTicks(320), new DateTime(2024, 10, 22, 21, 1, 16, 924, DateTimeKind.Local).AddTicks(320) });
        }
    }
}
