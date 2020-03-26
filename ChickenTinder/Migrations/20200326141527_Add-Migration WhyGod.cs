using Microsoft.EntityFrameworkCore.Migrations;

namespace ChickenTinder.Migrations
{
    public partial class AddMigrationWhyGod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Restaurants_Food_Types_Food_TypeId",
                table: "Restaurants");

            migrationBuilder.DropIndex(
                name: "IX_Restaurants_Food_TypeId",
                table: "Restaurants");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20f2eb51-580f-44c2-a788-f398dcecba06");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "Food_TypeId",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Chicken_Tinder_Users");

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Restaurants",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FoodTypeId",
                table: "Restaurants",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Chicken_Tinder_Users",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StreetAddress = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    ZipCode = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "724e2c8a-32c2-4a17-9af7-4a25691136be", "3e85fc58-4ac6-4e2f-aadd-f7dd322c43c5", "Chicken Tinder User", "CHICKEN TINDER USER" });

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_AddressId",
                table: "Restaurants",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_FoodTypeId",
                table: "Restaurants",
                column: "FoodTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Chicken_Tinder_Users_AddressId",
                table: "Chicken_Tinder_Users",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chicken_Tinder_Users_Addresses_AddressId",
                table: "Chicken_Tinder_Users",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Restaurants_Addresses_AddressId",
                table: "Restaurants",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Restaurants_Food_Types_FoodTypeId",
                table: "Restaurants",
                column: "FoodTypeId",
                principalTable: "Food_Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chicken_Tinder_Users_Addresses_AddressId",
                table: "Chicken_Tinder_Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Restaurants_Addresses_AddressId",
                table: "Restaurants");

            migrationBuilder.DropForeignKey(
                name: "FK_Restaurants_Food_Types_FoodTypeId",
                table: "Restaurants");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Restaurants_AddressId",
                table: "Restaurants");

            migrationBuilder.DropIndex(
                name: "IX_Restaurants_FoodTypeId",
                table: "Restaurants");

            migrationBuilder.DropIndex(
                name: "IX_Chicken_Tinder_Users_AddressId",
                table: "Chicken_Tinder_Users");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "724e2c8a-32c2-4a17-9af7-4a25691136be");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "FoodTypeId",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Chicken_Tinder_Users");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Food_TypeId",
                table: "Restaurants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "Latitude",
                table: "Restaurants",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Longitude",
                table: "Restaurants",
                type: "real",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Chicken_Tinder_Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "20f2eb51-580f-44c2-a788-f398dcecba06", "fbe650ce-be99-419c-a323-59749cd77b16", "Chicken Tinder User", "CHICKEN TINDER USER" });

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_Food_TypeId",
                table: "Restaurants",
                column: "Food_TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Restaurants_Food_Types_Food_TypeId",
                table: "Restaurants",
                column: "Food_TypeId",
                principalTable: "Food_Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
