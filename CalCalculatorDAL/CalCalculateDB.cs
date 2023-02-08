using CalCalculatorDAL.Configuration;
using CalCalculatorEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculatorDAL
{
    public class CalCalculateDB : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<FoodMeal> FoodMeals { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //DENİZ


            optionsBuilder.UseSqlServer("Server=DESKTOP-ES7IFME\\MSSQLKD14;Database=CalCalculateDB;Trusted_Connection=True");



            //ÇAĞDAŞ

            //optionsBuilder.UseSqlServer("Server=CHADO\\MSSQLKD14;Database=CalCalculateDB;Trusted_Connection=True");


            //YUŞA

            //optionsBuilder.UseSqlServer("Server=DESKTOP-GT7LVIF\\SQLEXPRESS;Database=CalCalculateDB;Trusted_Connection=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfigurations()).ApplyConfiguration(new MealConfiguration())
                .ApplyConfiguration(new FoodMealConfigurations());
            base.OnModelCreating(modelBuilder);
        }


    }
}
