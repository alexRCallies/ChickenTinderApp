using Microsoft.EntityFrameworkCore.Migrations;

namespace ChickenTinder.Migrations
{
    public partial class RestaurantUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a761c17-c216-47f9-abd2-04c1bbb00766");

            migrationBuilder.AddColumn<float>(
                name: "Latitude",
                table: "Restaurants",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Longitude",
                table: "Restaurants",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "20f2eb51-580f-44c2-a788-f398dcecba06", "fbe650ce-be99-419c-a323-59749cd77b16", "Chicken Tinder User", "CHICKEN TINDER USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20f2eb51-580f-44c2-a788-f398dcecba06");

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Restaurants");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8a761c17-c216-47f9-abd2-04c1bbb00766", "d63c3b81-083d-437c-a314-ceba3e1252bd", "Chicken Tinder User", "CHICKEN TINDER USER" });
        }
    }
}
