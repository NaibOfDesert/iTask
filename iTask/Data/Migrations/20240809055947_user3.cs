using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iTask.Data.Migrations
{
    /// <inheritdoc />
    public partial class user3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "798f824b-c93d-4f06-8482-83b8bd77028d");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c689b991-aa67-4f7a-9157-b7d4e6f89ca9", 0, "f6651b50-71d6-4365-a5e7-7904d1a922e9", "admin@admin.com", false, false, null, "Admin", null, null, "AQAAAAIAAYagAAAAENe6t0s+8LMZ01k6h/9uQjiHD0H5zZt72zk26TOEnFrzn/PuR0kHyRMILGoXKNc+MA==", null, false, "6eb08eeb-fff1-4cc0-8734-faf2cb26d215", false, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c689b991-aa67-4f7a-9157-b7d4e6f89ca9");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "798f824b-c93d-4f06-8482-83b8bd77028d", 0, "3a91c963-f293-40a0-b8ce-098bb10a76ff", "admin@admin.com", false, false, null, "Admin", null, null, "AQAAAAIAAYagAAAAENmMbgEqy+1EQFEKGo6DKMO9V8ZTXWj9TFfwT9deFMZupTGFbyKiJhPsqe15z1O3dg==", null, false, "89a5b467-fda6-42df-b1fa-fb6d69d3ea2b", false, null });
        }
    }
}
