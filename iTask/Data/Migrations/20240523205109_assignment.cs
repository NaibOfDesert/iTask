using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iTask.Data.Migrations
{
    /// <inheritdoc />
    public partial class assignment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.CreateTable(
                name: "TaAssignments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaAssignments", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TaAssignments",
                column: "Id",
                values: new object[]
                {
                    1,
                    2
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaAssignments");

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                column: "Id",
                values: new object[]
                {
                    1,
                    2
                });
        }
    }
}
