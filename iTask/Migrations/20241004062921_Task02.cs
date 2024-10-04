using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace iTask.Migrations
{
    /// <inheritdoc />
    public partial class Task02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.CreateTable(
                name: "Assignments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdProject = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    assignmentStatus = table.Column<int>(type: "int", nullable: false),
                    dateStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dateEnd = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignments", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "Id", "Description", "IdProject", "Name", "assignmentStatus", "dateEnd", "dateStart" },
                values: new object[,]
                {
                    { 1, "", 1, "Test1", 0, new DateTime(2024, 10, 11, 8, 29, 21, 881, DateTimeKind.Local).AddTicks(5370), new DateTime(2024, 10, 4, 8, 29, 21, 881, DateTimeKind.Local).AddTicks(5370) },
                    { 2, "", 2, "Test2", 0, new DateTime(2024, 10, 11, 8, 29, 21, 881, DateTimeKind.Local).AddTicks(5380), new DateTime(2024, 10, 4, 8, 29, 21, 881, DateTimeKind.Local).AddTicks(5380) },
                    { 3, "", 2, "Test33", 0, new DateTime(2024, 10, 11, 8, 29, 21, 881, DateTimeKind.Local).AddTicks(5380), new DateTime(2024, 10, 4, 8, 29, 21, 881, DateTimeKind.Local).AddTicks(5380) }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assignments");

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdProject = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    dateEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dateStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    taskStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2024, 10, 23, 22, 42, 6, 233, DateTimeKind.Local).AddTicks(9910), new DateTime(2024, 10, 3, 22, 42, 6, 233, DateTimeKind.Local).AddTicks(9850) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2024, 10, 23, 22, 42, 6, 233, DateTimeKind.Local).AddTicks(9920), new DateTime(2024, 10, 3, 22, 42, 6, 233, DateTimeKind.Local).AddTicks(9920) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2024, 10, 23, 22, 42, 6, 233, DateTimeKind.Local).AddTicks(9920), new DateTime(2024, 10, 3, 22, 42, 6, 233, DateTimeKind.Local).AddTicks(9920) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2024, 10, 23, 22, 42, 6, 233, DateTimeKind.Local).AddTicks(9930), new DateTime(2024, 10, 3, 22, 42, 6, 233, DateTimeKind.Local).AddTicks(9920) });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "Description", "IdProject", "Name", "dateEnd", "dateStart", "taskStatus" },
                values: new object[,]
                {
                    { 1, "", 1, "Test1", new DateTime(2024, 10, 10, 22, 42, 6, 233, DateTimeKind.Local).AddTicks(9990), new DateTime(2024, 10, 3, 22, 42, 6, 233, DateTimeKind.Local).AddTicks(9990), 0 },
                    { 2, "", 2, "Test2", new DateTime(2024, 10, 10, 22, 42, 6, 234, DateTimeKind.Local), new DateTime(2024, 10, 3, 22, 42, 6, 234, DateTimeKind.Local), 0 },
                    { 3, "", 2, "Test33", new DateTime(2024, 10, 10, 22, 42, 6, 234, DateTimeKind.Local), new DateTime(2024, 10, 3, 22, 42, 6, 234, DateTimeKind.Local), 0 }
                });
        }
    }
}
