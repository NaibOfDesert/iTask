using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iTask.Data.Migrations
{
    /// <inheritdoc />
    public partial class User4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c689b991-aa67-4f7a-9157-b7d4e6f89ca9");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "369833a2-658b-4510-885f-4c11ac10f874", 0, "c174d009-1932-449b-9315-b0ae04b1089a", "ApplicationUser", null, false, false, null, "Admin", null, null, null, null, false, "13cf83b9-510c-4958-8ec1-d8168c52ec9d", false, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "369833a2-658b-4510-885f-4c11ac10f874");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c689b991-aa67-4f7a-9157-b7d4e6f89ca9", 0, "f6651b50-71d6-4365-a5e7-7904d1a922e9", "admin@admin.com", false, false, null, "Admin", null, null, "AQAAAAIAAYagAAAAENe6t0s+8LMZ01k6h/9uQjiHD0H5zZt72zk26TOEnFrzn/PuR0kHyRMILGoXKNc+MA==", null, false, "6eb08eeb-fff1-4cc0-8734-faf2cb26d215", false, null });
        }
    }
}
