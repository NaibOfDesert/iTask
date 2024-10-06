using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iTask.Migrations
{
    /// <inheritdoc />
    public partial class ProjectTastk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "Assignments",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ProjectId", "dateEnd", "dateStart" },
                values: new object[] { null, new DateTime(2024, 10, 13, 16, 55, 9, 727, DateTimeKind.Local).AddTicks(3110), new DateTime(2024, 10, 6, 16, 55, 9, 727, DateTimeKind.Local).AddTicks(3110) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ProjectId", "dateEnd", "dateStart" },
                values: new object[] { null, new DateTime(2024, 10, 13, 16, 55, 9, 727, DateTimeKind.Local).AddTicks(3110), new DateTime(2024, 10, 6, 16, 55, 9, 727, DateTimeKind.Local).AddTicks(3110) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ProjectId", "dateEnd", "dateStart" },
                values: new object[] { null, new DateTime(2024, 10, 13, 16, 55, 9, 727, DateTimeKind.Local).AddTicks(3120), new DateTime(2024, 10, 6, 16, 55, 9, 727, DateTimeKind.Local).AddTicks(3120) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2024, 10, 26, 16, 55, 9, 727, DateTimeKind.Local).AddTicks(3020), new DateTime(2024, 10, 6, 16, 55, 9, 727, DateTimeKind.Local).AddTicks(2960) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2024, 10, 26, 16, 55, 9, 727, DateTimeKind.Local).AddTicks(3030), new DateTime(2024, 10, 6, 16, 55, 9, 727, DateTimeKind.Local).AddTicks(3030) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2024, 10, 26, 16, 55, 9, 727, DateTimeKind.Local).AddTicks(3030), new DateTime(2024, 10, 6, 16, 55, 9, 727, DateTimeKind.Local).AddTicks(3030) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2024, 10, 26, 16, 55, 9, 727, DateTimeKind.Local).AddTicks(3030), new DateTime(2024, 10, 6, 16, 55, 9, 727, DateTimeKind.Local).AddTicks(3030) });

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_ProjectId",
                table: "Assignments",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_Projects_ProjectId",
                table: "Assignments",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignments_Projects_ProjectId",
                table: "Assignments");

            migrationBuilder.DropIndex(
                name: "IX_Assignments_ProjectId",
                table: "Assignments");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Assignments");

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "dateEnd", "dateStart" },
                values: new object[] { new DateTime(2024, 10, 11, 8, 29, 21, 881, DateTimeKind.Local).AddTicks(5370), new DateTime(2024, 10, 4, 8, 29, 21, 881, DateTimeKind.Local).AddTicks(5370) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "dateEnd", "dateStart" },
                values: new object[] { new DateTime(2024, 10, 11, 8, 29, 21, 881, DateTimeKind.Local).AddTicks(5380), new DateTime(2024, 10, 4, 8, 29, 21, 881, DateTimeKind.Local).AddTicks(5380) });

            migrationBuilder.UpdateData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "dateEnd", "dateStart" },
                values: new object[] { new DateTime(2024, 10, 11, 8, 29, 21, 881, DateTimeKind.Local).AddTicks(5380), new DateTime(2024, 10, 4, 8, 29, 21, 881, DateTimeKind.Local).AddTicks(5380) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2024, 10, 24, 8, 29, 21, 881, DateTimeKind.Local).AddTicks(5280), new DateTime(2024, 10, 4, 8, 29, 21, 881, DateTimeKind.Local).AddTicks(5200) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2024, 10, 24, 8, 29, 21, 881, DateTimeKind.Local).AddTicks(5300), new DateTime(2024, 10, 4, 8, 29, 21, 881, DateTimeKind.Local).AddTicks(5300) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2024, 10, 24, 8, 29, 21, 881, DateTimeKind.Local).AddTicks(5300), new DateTime(2024, 10, 4, 8, 29, 21, 881, DateTimeKind.Local).AddTicks(5300) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2024, 10, 24, 8, 29, 21, 881, DateTimeKind.Local).AddTicks(5310), new DateTime(2024, 10, 4, 8, 29, 21, 881, DateTimeKind.Local).AddTicks(5310) });
        }
    }
}
