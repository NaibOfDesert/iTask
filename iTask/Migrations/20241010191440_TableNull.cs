using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iTask.Migrations
{
    /// <inheritdoc />
    public partial class TableNull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "IdProject",
                table: "Assignments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "dateEnd", "dateStart" },
                values: new object[] { new DateTime(2024, 10, 17, 21, 14, 40, 420, DateTimeKind.Local).AddTicks(3850), new DateTime(2024, 10, 10, 21, 14, 40, 420, DateTimeKind.Local).AddTicks(3850) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "dateEnd", "dateStart" },
                values: new object[] { new DateTime(2024, 10, 17, 21, 14, 40, 420, DateTimeKind.Local).AddTicks(3850), new DateTime(2024, 10, 10, 21, 14, 40, 420, DateTimeKind.Local).AddTicks(3850) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "dateEnd", "dateStart" },
                values: new object[] { new DateTime(2024, 10, 17, 21, 14, 40, 420, DateTimeKind.Local).AddTicks(3860), new DateTime(2024, 10, 10, 21, 14, 40, 420, DateTimeKind.Local).AddTicks(3860) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2024, 10, 30, 21, 14, 40, 420, DateTimeKind.Local).AddTicks(3760), new DateTime(2024, 10, 10, 21, 14, 40, 420, DateTimeKind.Local).AddTicks(3690) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2024, 10, 30, 21, 14, 40, 420, DateTimeKind.Local).AddTicks(3770), new DateTime(2024, 10, 10, 21, 14, 40, 420, DateTimeKind.Local).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2024, 10, 30, 21, 14, 40, 420, DateTimeKind.Local).AddTicks(3770), new DateTime(2024, 10, 10, 21, 14, 40, 420, DateTimeKind.Local).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2024, 10, 30, 21, 14, 40, 420, DateTimeKind.Local).AddTicks(3780), new DateTime(2024, 10, 10, 21, 14, 40, 420, DateTimeKind.Local).AddTicks(3780) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "IdProject",
                table: "Assignments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "dateEnd", "dateStart" },
                values: new object[] { new DateTime(2024, 10, 13, 23, 7, 11, 45, DateTimeKind.Local).AddTicks(180), new DateTime(2024, 10, 6, 23, 7, 11, 45, DateTimeKind.Local).AddTicks(170) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "dateEnd", "dateStart" },
                values: new object[] { new DateTime(2024, 10, 13, 23, 7, 11, 45, DateTimeKind.Local).AddTicks(180), new DateTime(2024, 10, 6, 23, 7, 11, 45, DateTimeKind.Local).AddTicks(180) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "dateEnd", "dateStart" },
                values: new object[] { new DateTime(2024, 10, 13, 23, 7, 11, 45, DateTimeKind.Local).AddTicks(180), new DateTime(2024, 10, 6, 23, 7, 11, 45, DateTimeKind.Local).AddTicks(180) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2024, 10, 26, 23, 7, 11, 45, DateTimeKind.Local).AddTicks(80), new DateTime(2024, 10, 6, 23, 7, 11, 45, DateTimeKind.Local).AddTicks(30) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2024, 10, 26, 23, 7, 11, 45, DateTimeKind.Local).AddTicks(90), new DateTime(2024, 10, 6, 23, 7, 11, 45, DateTimeKind.Local).AddTicks(90) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2024, 10, 26, 23, 7, 11, 45, DateTimeKind.Local).AddTicks(100), new DateTime(2024, 10, 6, 23, 7, 11, 45, DateTimeKind.Local).AddTicks(100) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2024, 10, 26, 23, 7, 11, 45, DateTimeKind.Local).AddTicks(100), new DateTime(2024, 10, 6, 23, 7, 11, 45, DateTimeKind.Local).AddTicks(100) });
        }
    }
}
