using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iTask.Data.Migrations
{
    /// <inheritdoc />
    public partial class Projects01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Project",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "State",
                table: "Project",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "State" },
                values: new object[] { "Project1", 0 });

            migrationBuilder.UpdateData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "State" },
                values: new object[] { "Project2", 0 });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "Id", "Name", "State" },
                values: new object[] { 33, "Project33", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Project",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Project");
        }
    }
}
