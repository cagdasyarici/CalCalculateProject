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
                    { 1, 2, 37.0, 10, 0, "Coke", 0 },
                    { 2, 2, 54.0, 13, 0, "Juice", 0 },
                    { 3, 2, 1.0, 0, 0, "Tea", 0 },
                    { 4, 2, 1.0, 0, 0, "Coffee", 0 },
                    { 5, 2, 95.0, 24, 0, "Soda", 0 },
                    { 6, 1, 359.0, 90, 0, "Turkish Delight", 0 },
                    { 7, 1, 428.0, 38, 29, "Baklava", 7 },
                    { 8, 1, 130.0, 20, 4, "Kazandibi", 3 },
                    { 9, 1, 452.0, 62, 21, "Caramel Waffle", 3 },
                    { 10, 1, 429.0, 56, 20, "Profiterole", 6 },
                    { 11, 3, 216.0, 0, 15, "Bonito", 20 },
                    { 12, 3, 124.0, 0, 3, "Red Mullet", 20 },
                    { 13, 3, 96.0, 0, 2, "Bream", 20 },
                    { 14, 3, 164.0, 5, 2, "Octopus", 30 },
                    { 15, 3, 89.0, 3, 5, "Moules Provencales", 8 },
                    { 16, 4, 385.0, 27, 29, "Chocolate Cake", 5 },
                    { 17, 4, 172.0, 27, 5, "Fruit Cake", 4 },
                    { 18, 5, 165.0, 20, 6, "Burger", 7 },
                    { 19, 5, 186.0, 31, 5, "Pizza", 6 },
                    { 20, 5, 253.0, 28, 12, "Hotdog", 9 },
                    { 21, 5, 128.0, 9, 20, "Doner", 9 },
                    { 22, 5, 280.0, 37, 13, "Fried Potatoes", 4 },
                    { 23, 6, 56.0, 14, 1, "Apple", 1 },
                    { 24, 6, 28.0, 7, 1, "Melon", 1 },
                    { 25, 6, 100.0, 25, 1, "Watermelon", 0 },
                    { 26, 6, 69.0, 18, 0, "Grape", 1 },
                    { 27, 6, 74.0, 19, 0, "Fig", 1 },
                    { 28, 7, 24.0, 5, 2, "Cauliflower", 1 },
                    { 29, 7, 17.0, 3, 0, "Eggplant", 2 },
                    { 30, 7, 26.0, 3, 0, "Broccoli", 4 },
                    { 31, 7, 53.0, 12, 1, "Artichoke", 3 },
                    { 32, 7, 226.0, 2, 25, "Fried Cabbage", 2 },
                    { 33, 8, 539.0, 57, 35, "Corn Chips", 7 },
                    { 34, 8, 532.0, 8, 56, "Potato Chips", 1 },
                    { 35, 8, 474.0, 72, 4, "Oreos", 19 },
                    { 36, 8, 525.0, 40, 37, "Popcorn", 7 },
                    { 37, 8, 335.0, 76, 0, "Jelly Bears", 7 },
                    { 38, 9, 239.0, 1, 20, "Adana Kebab", 14 },
                    { 39, 9, 151.0, 16, 6, "Iskender Kebab", 10 },
                    { 40, 9, 141.0, 12, 1, "Chicken Kebab", 21 },
                    { 41, 11, 54.0, 5, 4, "Iceberg Lettuce Salad", 1 },
                    { 42, 11, 128.0, 7, 5, "Caesar Salad", 14 }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "FoodID", "CategoryId", "FoodCal", "FoodCarb", "FoodFat", "FoodName", "FoodProt" },
                values: new object[,]
                {
                    { 43, 11, 128.0, 7, 5, "Caesar Salad", 14 },
                    { 44, 12, 310.0, 3, 25, "Feta Cheese", 21 },
                    { 45, 12, 207.0, 2, 21, "Olive", 2 },
                    { 46, 12, 378.0, 81, 2, "Cereal", 7 },
                    { 47, 12, 229.0, 25, 11, "French Toast", 8 },
                    { 48, 13, 256.0, 53, 1, "Bread", 8 },
                    { 49, 13, 216.0, 45, 2, "Wholewheat Bread", 6 },
                    { 50, 13, 275.0, 58, 4, "Bagel", 10 },
                    { 51, 13, 275.0, 58, 4, "Savory Bun", 10 }
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
