using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iTask.Data.Migrations
{
    /// <inheritdoc />
    public partial class NewDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "369833a2-658b-4510-885f-4c11ac10f874");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4a094c17-981c-46ee-ae67-823db4241ee0", 0, "a755887b-5021-42b9-a7f5-aabc0d70c9b5", "ApplicationUser", null, false, false, null, "Admin", null, null, null, null, false, "402974ed-56b5-472c-ac2d-7387af014ffb", false, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4a094c17-981c-46ee-ae67-823db4241ee0");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "369833a2-658b-4510-885f-4c11ac10f874", 0, "c174d009-1932-449b-9315-b0ae04b1089a", "ApplicationUser", null, false, false, null, "Admin", null, null, null, null, false, "13cf83b9-510c-4958-8ec1-d8168c52ec9d", false, null });
        }
    }
}
