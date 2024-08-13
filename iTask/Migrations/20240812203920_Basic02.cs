using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iTask.Migrations
{
    /// <inheritdoc />
    public partial class Basic02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e2c4644-7170-4d47-a405-6debff4ac68c");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3874939c-87b6-4a09-8682-7ecc6acbfd22", 0, "faad62c8-4ed5-4eb6-a6c0-e76c0574b4cb", "ApplicationUser", null, false, false, null, "Admin", null, null, null, null, false, "3ca98649-c09e-4968-96da-1a2cfae163c6", false, null });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Name", "State" },
                values: new object[] { 34, "Project34", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3874939c-87b6-4a09-8682-7ecc6acbfd22");

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1e2c4644-7170-4d47-a405-6debff4ac68c", 0, "3e79eefc-7361-4b99-bcff-c8e29a66e00a", "ApplicationUser", null, false, false, null, "Admin", null, null, null, null, false, "2b9122c2-1bd2-4925-88fc-1c9170f9cc65", false, null });
        }
    }
}
