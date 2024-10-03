using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace iTask.Migrations
{
    /// <inheritdoc />
    public partial class Tasks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Task_Projects_projectAffiliationId",
                table: "Task");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Task",
                table: "Task");

            migrationBuilder.DropIndex(
                name: "IX_Task_projectAffiliationId",
                table: "Task");

            migrationBuilder.RenameTable(
                name: "Task",
                newName: "Tasks");

            migrationBuilder.RenameColumn(
                name: "projectAffiliationId",
                table: "Tasks",
                newName: "IdProject");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tasks",
                table: "Tasks",
                column: "Id");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Tasks",
                table: "Tasks");

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.RenameTable(
                name: "Tasks",
                newName: "Task");

            migrationBuilder.RenameColumn(
                name: "IdProject",
                table: "Task",
                newName: "projectAffiliationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Task",
                table: "Task",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Task_Projects_projectAffiliationId",
                table: "Task",
                column: "projectAffiliationId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
