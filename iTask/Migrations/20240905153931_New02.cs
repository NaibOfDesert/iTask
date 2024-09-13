using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace iTask.Migrations
{
    /// <inheritdoc />
    public partial class New02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "98744157-564e-442f-8af7-fd7d95f0b5de", 0, "8225db18-024e-40f7-a610-a4bfba8fd417", "admin@admin.com", false, false, null, "Admin", null, null, "AQAAAAIAAYagAAAAEBDaGoMVPjwBAN1h7bLvqcKfUNNlA5MswUr/DHzKZCDT4ZwqHERT6hLJMJq8mMbSFQ==", null, false, "1ffe8b9f-ccc4-48cc-99ac-139af64eea73", false, null });

            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "Id", "State" },
                values: new object[,]
                {
                    { 1, 0 },
                    { 2, 0 }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Name", "State" },
                values: new object[,]
                {
                    { 1, "Project1", 0 },
                    { 2, "Project2", 0 },
                    { 33, "Project33", 1 },
                    { 34, "Project34", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "98744157-564e-442f-8af7-fd7d95f0b5de");

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Assignments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 34);
        }
    }
}
