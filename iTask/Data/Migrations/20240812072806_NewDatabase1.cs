using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iTask.Data.Migrations
{
    /// <inheritdoc />
    public partial class NewDatabase1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4a094c17-981c-46ee-ae67-823db4241ee0");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3af7073a-7607-4bae-a7f6-a1d20478bfdf", 0, "b4f85f3e-d54b-406f-a797-f26fbfe8b35d", "ApplicationUser", null, false, false, null, "Admin", null, null, null, null, false, "605c2fc1-f270-435e-a668-77741165401f", false, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3af7073a-7607-4bae-a7f6-a1d20478bfdf");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4a094c17-981c-46ee-ae67-823db4241ee0", 0, "a755887b-5021-42b9-a7f5-aabc0d70c9b5", "ApplicationUser", null, false, false, null, "Admin", null, null, null, null, false, "402974ed-56b5-472c-ac2d-7387af014ffb", false, null });
        }
    }
}
