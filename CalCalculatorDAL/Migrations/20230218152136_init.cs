using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalCalculatorDAL.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SecurityQuestion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecurityAnswer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    FoodID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoodCarb = table.Column<int>(type: "int", nullable: false),
                    FoodFat = table.Column<int>(type: "int", nullable: false),
                    FoodProt = table.Column<int>(type: "int", nullable: false),
                    FoodCal = table.Column<double>(type: "float", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.FoodID);
                    table.ForeignKey(
                        name: "FK_Foods_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    MealID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MealName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ContactUserID = table.Column<int>(type: "int", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalCalorie = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.MealID);
                    table.ForeignKey(
                        name: "FK_Meals_Users_ContactUserID",
                        column: x => x.ContactUserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodMeals",
                columns: table => new
                {
                    FoodID = table.Column<int>(type: "int", nullable: false),
                    MealID = table.Column<int>(type: "int", nullable: false),
                    Grams = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodMeals", x => new { x.MealID, x.FoodID });
                    table.ForeignKey(
                        name: "FK_FoodMeals_Foods_FoodID",
                        column: x => x.FoodID,
                        principalTable: "Foods",
                        principalColumn: "FoodID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodMeals_Meals_MealID",
                        column: x => x.MealID,
                        principalTable: "Meals",
                        principalColumn: "MealID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Desserts" },
                    { 2, "Drinks" },
                    { 3, "Sea Foods" },
                    { 4, "Pastries" },
                    { 5, "Fast Foods" },
                    { 6, "Fruits" },
                    { 7, "Vegetable" },
                    { 8, "Snacks" },
                    { 9, "Kebabs" },
                    { 10, "Legumes" },
                    { 11, "Salads" },
                    { 12, "Breakfast Foods" },
                    { 13, "Bakery" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserID", "Email", "IsAdmin", "Password", "SecurityAnswer", "SecurityQuestion", "UserName" },
                values: new object[] { 1, "admin@", true, "admin", "adminSecurityAnswer", "adminSecurityQuestion", "admin" });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodID", "CategoryId", "FoodCal", "FoodCarb", "FoodFat", "FoodName", "FoodProt" },
                values: new object[,]
                {
                    { 1, 2, 37.0, 10, 0, "Cola", 0 },
                    { 2, 2, 54.0, 13, 0, "Juice", 0 },
                    { 3, 2, 1.0, 0, 0, "Tea", 0 },
                    { 4, 2, 1.0, 0, 0, "Coffee", 0 },
                    { 5, 1, 359.0, 90, 0, "Turkish Delight", 0 },
                    { 6, 1, 428.0, 38, 29, "Baklava", 7 },
                    { 7, 3, 216.0, 0, 15, "Bonito", 20 },
                    { 8, 3, 124.0, 0, 3, "Red Mullet", 20 },
                    { 9, 3, 96.0, 0, 2, "Bream", 20 },
                    { 10, 4, 385.0, 27, 29, "Chocolate Cake", 5 },
                    { 11, 4, 172.0, 27, 5, "Fruit Cake", 4 },
                    { 12, 5, 165.0, 20, 6, "Burger", 7 },
                    { 13, 5, 186.0, 31, 5, "Pizza", 6 },
                    { 14, 6, 56.0, 14, 1, "Apple", 1 },
                    { 15, 6, 28.0, 7, 1, "Melon", 1 },
                    { 16, 7, 24.0, 5, 2, "Cauliflower", 1 },
                    { 17, 7, 53.0, 12, 1, "Cauliflower", 2 },
                    { 18, 8, 539.0, 57, 35, "Corn Chips", 7 },
                    { 19, 8, 532.0, 8, 56, "Corn Chips", 1 },
                    { 20, 9, 239.0, 1, 20, "Adana Kebab", 14 },
                    { 21, 9, 151.0, 16, 6, "Iskender Kebab", 10 },
                    { 22, 11, 54.0, 5, 4, "Iceberg Lettuce Salad", 1 },
                    { 23, 11, 128.0, 7, 5, "Caesar Salad", 14 },
                    { 24, 12, 310.0, 3, 25, "Feta Cheese", 21 },
                    { 25, 12, 207.0, 2, 21, "Olive", 2 },
                    { 26, 13, 256.0, 53, 1, "Bread", 8 },
                    { 27, 13, 216.0, 45, 2, "Wholewheat Bread", 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FoodMeals_FoodID",
                table: "FoodMeals",
                column: "FoodID");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_CategoryId",
                table: "Foods",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Meals_ContactUserID",
                table: "Meals",
                column: "ContactUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserName",
                table: "Users",
                column: "UserName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodMeals");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
