using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iTask.Migrations
{
    /// <inheritdoc />
    public partial class AssignmentDescriptionNull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Assignments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart", "Description" },
                values: new object[] { new DateTime(2024, 10, 29, 21, 1, 16, 924, DateTimeKind.Local).AddTicks(390), new DateTime(2024, 10, 22, 21, 1, 16, 924, DateTimeKind.Local).AddTicks(380), null });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart", "Description" },
                values: new object[] { new DateTime(2024, 10, 29, 21, 1, 16, 924, DateTimeKind.Local).AddTicks(390), new DateTime(2024, 10, 22, 21, 1, 16, 924, DateTimeKind.Local).AddTicks(390), null });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateEnd", "DateStart", "Description" },
                values: new object[] { new DateTime(2024, 10, 29, 21, 1, 16, 924, DateTimeKind.Local).AddTicks(390), new DateTime(2024, 10, 22, 21, 1, 16, 924, DateTimeKind.Local).AddTicks(390), null });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Assignments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart", "Description" },
                values: new object[] { new DateTime(2024, 10, 29, 17, 16, 43, 51, DateTimeKind.Local).AddTicks(6420), new DateTime(2024, 10, 22, 17, 16, 43, 51, DateTimeKind.Local).AddTicks(6410), "" });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart", "Description" },
                values: new object[] { new DateTime(2024, 10, 29, 17, 16, 43, 51, DateTimeKind.Local).AddTicks(6420), new DateTime(2024, 10, 22, 17, 16, 43, 51, DateTimeKind.Local).AddTicks(6420), "" });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateEnd", "DateStart", "Description" },
                values: new object[] { new DateTime(2024, 10, 29, 17, 16, 43, 51, DateTimeKind.Local).AddTicks(6420), new DateTime(2024, 10, 22, 17, 16, 43, 51, DateTimeKind.Local).AddTicks(6420), "" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2024, 11, 11, 17, 16, 43, 51, DateTimeKind.Local).AddTicks(6340), new DateTime(2024, 10, 22, 17, 16, 43, 51, DateTimeKind.Local).AddTicks(6320) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2024, 11, 11, 17, 16, 43, 51, DateTimeKind.Local).AddTicks(6350), new DateTime(2024, 10, 22, 17, 16, 43, 51, DateTimeKind.Local).AddTicks(6350) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2024, 11, 11, 17, 16, 43, 51, DateTimeKind.Local).AddTicks(6350), new DateTime(2024, 10, 22, 17, 16, 43, 51, DateTimeKind.Local).AddTicks(6350) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2024, 11, 11, 17, 16, 43, 51, DateTimeKind.Local).AddTicks(6360), new DateTime(2024, 10, 22, 17, 16, 43, 51, DateTimeKind.Local).AddTicks(6350) });
        }
    }
}
