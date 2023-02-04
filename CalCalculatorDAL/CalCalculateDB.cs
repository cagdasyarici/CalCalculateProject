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
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=DENIZ;Database=CalCalculatorProgramDB;Trusted_Connection=True");

            //optionsBuilder.UseSqlServer("Server=CHADO\\MSSQLKD14;Database=CalCalculatorProgramDB;Trusted_Connection=True;");
        }
    }
}
