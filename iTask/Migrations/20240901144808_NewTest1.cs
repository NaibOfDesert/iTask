using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iTask.Migrations
{
    /// <inheritdoc />
    public partial class NewTest1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7dbeabaf-29ab-4f2b-848f-90c4fff94ef1");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "76bcc84d-8f63-43da-b208-6a7dce015fc0", 0, "bb82d0dd-a948-41dd-832e-b2fc05bfb2b2", "admin@admin.com", false, false, null, "Admin", null, null, "AQAAAAIAAYagAAAAEBaNO9L7o3omqi/lcRAevH0bqwniJCU8bh533l7rvK//Fs1L9wEJGhU1gU5A1BE1Tw==", null, false, "c1d826bf-295b-45cf-9d53-65d3d42b8f01", false, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "76bcc84d-8f63-43da-b208-6a7dce015fc0");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7dbeabaf-29ab-4f2b-848f-90c4fff94ef1", 0, "40e87842-9b5f-43fd-b004-09083b469968", "ApplicationUser", null, false, false, null, "Admin", null, null, null, null, false, "3eb432a7-ec42-4d2f-8a36-b8f7e3174d74", false, null });
        }
    }
}
