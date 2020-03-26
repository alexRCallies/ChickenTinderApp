using Microsoft.EntityFrameworkCore.Migrations;

namespace ChickenTinder.Migrations
{
    public partial class RemovedKeyForJunction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "51aafa11-6fb6-47ed-a5a4-4d35ca9bc95b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8a761c17-c216-47f9-abd2-04c1bbb00766", "d63c3b81-083d-437c-a314-ceba3e1252bd", "Chicken Tinder User", "CHICKEN TINDER USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a761c17-c216-47f9-abd2-04c1bbb00766");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "51aafa11-6fb6-47ed-a5a4-4d35ca9bc95b", "541a0b76-596f-4d94-867c-d070a8c79d90", "Chicken Tinder User", "CHICKEN TINDER USER" });
        }
    }
}
