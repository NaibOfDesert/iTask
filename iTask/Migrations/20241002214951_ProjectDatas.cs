using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iTask.Migrations
{
    /// <inheritdoc />
    public partial class ProjectDatas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateEnd",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateStart",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Task",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    taskStatus = table.Column<int>(type: "int", nullable: false),
                    dateStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    dateEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    projectAffiliationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Task", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Task_Projects_projectAffiliationId",
                        column: x => x.projectAffiliationId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2024, 10, 22, 23, 49, 51, 619, DateTimeKind.Local).AddTicks(3600), new DateTime(2024, 10, 2, 23, 49, 51, 619, DateTimeKind.Local).AddTicks(3540) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2024, 10, 22, 23, 49, 51, 619, DateTimeKind.Local).AddTicks(3610), new DateTime(2024, 10, 2, 23, 49, 51, 619, DateTimeKind.Local).AddTicks(3610) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2024, 10, 22, 23, 49, 51, 619, DateTimeKind.Local).AddTicks(3610), new DateTime(2024, 10, 2, 23, 49, 51, 619, DateTimeKind.Local).AddTicks(3610) });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateEnd", "DateStart" },
                values: new object[] { new DateTime(2024, 10, 22, 23, 49, 51, 619, DateTimeKind.Local).AddTicks(3620), new DateTime(2024, 10, 2, 23, 49, 51, 619, DateTimeKind.Local).AddTicks(3610) });

            migrationBuilder.CreateIndex(
                name: "IX_Task_projectAffiliationId",
                table: "Task",
                column: "projectAffiliationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Task");

            migrationBuilder.DropColumn(
                name: "DateEnd",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "DateStart",
                table: "Projects");
        }
    }
}
