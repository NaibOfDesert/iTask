using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iTask.Migrations
{
    /// <inheritdoc />
    public partial class ProjectTask02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "dateEnd", "dateStart" },
                values: new object[] { new DateTime(2024, 10, 13, 17, 0, 21, 28, DateTimeKind.Local).AddTicks(9250), new DateTime(2024, 10, 6, 17, 0, 21, 28, DateTimeKind.Local).AddTicks(9250) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "dateEnd", "dateStart" },
                values: new object[] { new DateTime(2024, 10, 13, 17, 0, 21, 28, DateTimeKind.Local).AddTicks(9260), new DateTime(2024, 10, 6, 17, 0, 21, 28, DateTimeKind.Local).AddTicks(9260) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "dateEnd", "dateStart" },
                values: new object[] { new DateTime(2024, 10, 13, 17, 0, 21, 28, DateTimeKind.Local).AddTicks(9260), new DateTime(2024, 10, 6, 17, 0, 21, 28, DateTimeKind.Local).AddTicks(9260) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2024, 10, 26, 17, 0, 21, 28, DateTimeKind.Local).AddTicks(9170), new DateTime(2024, 10, 6, 17, 0, 21, 28, DateTimeKind.Local).AddTicks(9140) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2024, 10, 26, 17, 0, 21, 28, DateTimeKind.Local).AddTicks(9180), new DateTime(2024, 10, 6, 17, 0, 21, 28, DateTimeKind.Local).AddTicks(9180) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2024, 10, 26, 17, 0, 21, 28, DateTimeKind.Local).AddTicks(9190), new DateTime(2024, 10, 6, 17, 0, 21, 28, DateTimeKind.Local).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2024, 10, 26, 17, 0, 21, 28, DateTimeKind.Local).AddTicks(9190), new DateTime(2024, 10, 6, 17, 0, 21, 28, DateTimeKind.Local).AddTicks(9190) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "dateEnd", "dateStart" },
                values: new object[] { new DateTime(2024, 10, 13, 16, 58, 18, 202, DateTimeKind.Local).AddTicks(9070), new DateTime(2024, 10, 6, 16, 58, 18, 202, DateTimeKind.Local).AddTicks(9070) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "dateEnd", "dateStart" },
                values: new object[] { new DateTime(2024, 10, 13, 16, 58, 18, 202, DateTimeKind.Local).AddTicks(9080), new DateTime(2024, 10, 6, 16, 58, 18, 202, DateTimeKind.Local).AddTicks(9080) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "dateEnd", "dateStart" },
                values: new object[] { new DateTime(2024, 10, 13, 16, 58, 18, 202, DateTimeKind.Local).AddTicks(9080), new DateTime(2024, 10, 6, 16, 58, 18, 202, DateTimeKind.Local).AddTicks(9080) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2024, 10, 26, 16, 58, 18, 202, DateTimeKind.Local).AddTicks(8990), new DateTime(2024, 10, 6, 16, 58, 18, 202, DateTimeKind.Local).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2024, 10, 26, 16, 58, 18, 202, DateTimeKind.Local).AddTicks(9000), new DateTime(2024, 10, 6, 16, 58, 18, 202, DateTimeKind.Local).AddTicks(9000) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2024, 10, 26, 16, 58, 18, 202, DateTimeKind.Local).AddTicks(9010), new DateTime(2024, 10, 6, 16, 58, 18, 202, DateTimeKind.Local).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2024, 10, 26, 16, 58, 18, 202, DateTimeKind.Local).AddTicks(9010), new DateTime(2024, 10, 6, 16, 58, 18, 202, DateTimeKind.Local).AddTicks(9010) });
        }
    }
}
