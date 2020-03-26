using Microsoft.EntityFrameworkCore.Migrations;

namespace ChickenTinder.Migrations
{
    public partial class PlzPlz : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Restaurants_Addresses_AddressId",
                table: "Restaurants");

            migrationBuilder.DropForeignKey(
                name: "FK_Restaurants_Food_Types_FoodTypeId",
                table: "Restaurants");

            migrationBuilder.DropIndex(
                name: "IX_Restaurants_AddressId",
                table: "Restaurants");

            migrationBuilder.DropIndex(
                name: "IX_Restaurants_FoodTypeId",
                table: "Restaurants");

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

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Restaurants",
                newName: "ID");

            migrationBuilder.AddColumn<int>(
                name: "AverageCostForTwo",
                table: "Restaurants",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Cuisines",
                table: "Restaurants",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Currency",
                table: "Restaurants",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocationID",
                table: "Restaurants",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    latitude = table.Column<string>(nullable: true),
                    longitude = table.Column<string>(nullable: true),
                    LocalityVerbose = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "140acd2f-f292-4f25-b0dc-d79ff4a31e61", "d5b890be-18b0-45fd-b6f2-44696c12bd3f", "Chicken Tinder User", "CHICKEN TINDER USER" });

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_LocationID",
                table: "Restaurants",
                column: "LocationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Restaurants_Location_LocationID",
                table: "Restaurants",
                column: "LocationID",
                principalTable: "Location",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Restaurants_Location_LocationID",
                table: "Restaurants");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropIndex(
                name: "IX_Restaurants_LocationID",
                table: "Restaurants");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "140acd2f-f292-4f25-b0dc-d79ff4a31e61");

            migrationBuilder.DropColumn(
                name: "AverageCostForTwo",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "Cuisines",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "Currency",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "LocationID",
                table: "Restaurants");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Restaurants",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Restaurants",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FoodTypeId",
                table: "Restaurants",
                type: "int",
                nullable: true);

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
    }
}
