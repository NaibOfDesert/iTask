using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iTask.Data.Migrations
{
    /// <inheritdoc />
    public partial class User1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f36ee45-dc33-4c62-9f83-d8dce58c0205");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e0d0d4e0-30a7-4675-8760-e6eb165cb99c", 0, "187b37ed-4372-4dd3-88ce-5ebe8d84c355", "admin@admin.com", false, false, null, "Admin", null, null, "AQAAAAIAAYagAAAAEEswZbvKvdGj2V39b8jtigmyT873i64OxGY75QIVFNgzKZpJoON3w4it6BpHXDu/gQ==", null, false, "feba4ee3-7edd-412b-b4d0-1b60e3f45885", false, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e0d0d4e0-30a7-4675-8760-e6eb165cb99c");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4f36ee45-dc33-4c62-9f83-d8dce58c0205", 0, "52df6b28-a2fc-4a07-8132-288ac55f1570", "ApplicationUser", null, false, false, null, "Admin", null, null, null, null, false, "5722e666-e7c3-4837-bca1-0ab03e728029", false, null });
        }
    }
}
