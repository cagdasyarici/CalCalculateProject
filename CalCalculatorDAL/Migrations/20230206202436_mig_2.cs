using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalCalculatorDAL.Migrations
{
    public partial class mig_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Grams",
                table: "Foods");

            migrationBuilder.AddColumn<int>(
                name: "Grams",
                table: "FoodMeals",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Grams",
                table: "FoodMeals");

            migrationBuilder.AddColumn<int>(
                name: "Grams",
                table: "Foods",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
