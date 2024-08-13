using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iTask.Migrations
{
    /// <inheritdoc />
    public partial class Basic03 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3874939c-87b6-4a09-8682-7ecc6acbfd22");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7dbeabaf-29ab-4f2b-848f-90c4fff94ef1", 0, "40e87842-9b5f-43fd-b004-09083b469968", "ApplicationUser", null, false, false, null, "Admin", null, null, null, null, false, "3eb432a7-ec42-4d2f-8a36-b8f7e3174d74", false, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7dbeabaf-29ab-4f2b-848f-90c4fff94ef1");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3874939c-87b6-4a09-8682-7ecc6acbfd22", 0, "faad62c8-4ed5-4eb6-a6c0-e76c0574b4cb", "ApplicationUser", null, false, false, null, "Admin", null, null, null, null, false, "3ca98649-c09e-4968-96da-1a2cfae163c6", false, null });
        }
    }
}
