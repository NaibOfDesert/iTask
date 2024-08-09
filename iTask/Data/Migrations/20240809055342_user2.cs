using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace iTask.Data.Migrations
{
    /// <inheritdoc />
    public partial class user2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e0d0d4e0-30a7-4675-8760-e6eb165cb99c");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "798f824b-c93d-4f06-8482-83b8bd77028d", 0, "3a91c963-f293-40a0-b8ce-098bb10a76ff", "admin@admin.com", false, false, null, "Admin", null, null, "AQAAAAIAAYagAAAAENmMbgEqy+1EQFEKGo6DKMO9V8ZTXWj9TFfwT9deFMZupTGFbyKiJhPsqe15z1O3dg==", null, false, "89a5b467-fda6-42df-b1fa-fb6d69d3ea2b", false, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "798f824b-c93d-4f06-8482-83b8bd77028d");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e0d0d4e0-30a7-4675-8760-e6eb165cb99c", 0, "187b37ed-4372-4dd3-88ce-5ebe8d84c355", "admin@admin.com", false, false, null, "Admin", null, null, "AQAAAAIAAYagAAAAEEswZbvKvdGj2V39b8jtigmyT873i64OxGY75QIVFNgzKZpJoON3w4it6BpHXDu/gQ==", null, false, "feba4ee3-7edd-412b-b4d0-1b60e3f45885", false, null });
        }
    }
}
