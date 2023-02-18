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


            optionsBuilder.UseSqlServer("Server=DENIZ;Database=CalCalculateDB;Trusted_Connection=True");



            //ÇAĞDAŞ

            //optionsBuilder.UseSqlServer("Server=CHADO\\MSSQLKD14;Database=CalCalculateDB7;Trusted_Connection=True");


            //YUŞA

            //optionsBuilder.UseSqlServer("Server=YUSATOSUN\\SQLEXPRESS;Database=CalCalculateDB;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfigurations()).ApplyConfiguration(new MealConfiguration())
                .ApplyConfiguration(new FoodMealConfigurations());
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(CreateCategory(1,"Desserts"));
            modelBuilder.Entity<Category>().HasData(CreateCategory(2,"Drinks"));
            modelBuilder.Entity<Category>().HasData(CreateCategory(3,"Sea Foods"));
            modelBuilder.Entity<Category>().HasData(CreateCategory(4,"Pastries"));
            modelBuilder.Entity<Category>().HasData(CreateCategory(5,"Fast Foods"));
            modelBuilder.Entity<Category>().HasData(CreateCategory(6,"Fruits"));
            modelBuilder.Entity<Category>().HasData(CreateCategory(7,"Vegetable"));
            modelBuilder.Entity<Category>().HasData(CreateCategory(8,"Snacks"));
            modelBuilder.Entity<Category>().HasData(CreateCategory(9,"Kebabs"));
            modelBuilder.Entity<Category>().HasData(CreateCategory(10,"Legumes"));
            modelBuilder.Entity<Category>().HasData(CreateCategory(11,"Salads"));
            modelBuilder.Entity<Category>().HasData(CreateCategory(12,"Breakfast Foods"));
            modelBuilder.Entity<Category>().HasData(CreateCategory(13,"Bakery"));

            modelBuilder.Entity<Food>().HasData(CreateFood(1,"Cola", 37, 10, 0, 0, 2));
            modelBuilder.Entity<Food>().HasData(CreateFood(2,"Juice", 54, 13, 0, 0, 2));
            modelBuilder.Entity<Food>().HasData(CreateFood(3,"Tea", 1, 0, 0, 0, 2));
            modelBuilder.Entity<Food>().HasData(CreateFood(4,"Coffee", 1, 0, 0, 0, 2));
            modelBuilder.Entity<Food>().HasData(CreateFood(5,"Turkish Delight", 359, 90, 0, 0, 1));
            modelBuilder.Entity<Food>().HasData(CreateFood(6,"Baklava", 428, 38, 29, 7, 1));
            modelBuilder.Entity<Food>().HasData(CreateFood(7,"Bonito", 216, 0, 15, 20, 3));
            modelBuilder.Entity<Food>().HasData(CreateFood(8,"Red Mullet", 124, 0, 3, 20, 3));
            modelBuilder.Entity<Food>().HasData(CreateFood(9,"Bream", 96, 0, 2, 20, 3));
            modelBuilder.Entity<Food>().HasData(CreateFood(10, "Chocolate Cake", 385, 27, 29, 5, 4));
            modelBuilder.Entity<Food>().HasData(CreateFood(11, "Fruit Cake", 172, 27, 5, 4, 4));
            modelBuilder.Entity<Food>().HasData(CreateFood(12, "Burger", 165, 20, 6, 7, 5));
            modelBuilder.Entity<Food>().HasData(CreateFood(13, "Pizza", 186, 31, 5, 6, 5));
            modelBuilder.Entity<Food>().HasData(CreateFood(14, "Apple", 56, 14, 1, 1, 6));
            modelBuilder.Entity<Food>().HasData(CreateFood(15, "Melon", 28, 7, 1, 1, 6));
            modelBuilder.Entity<Food>().HasData(CreateFood(16, "Cauliflower", 24, 5, 2, 1, 7));
            modelBuilder.Entity<Food>().HasData(CreateFood(17, "Cauliflower", 53, 12, 1, 2, 7));
            modelBuilder.Entity<Food>().HasData(CreateFood(18, "Corn Chips", 539, 57, 35, 7, 8));
            modelBuilder.Entity<Food>().HasData(CreateFood(19, "Corn Chips", 532, 8, 56, 1, 8));
            modelBuilder.Entity<Food>().HasData(CreateFood(20, "Adana Kebab", 239, 1, 20, 14, 9));
            modelBuilder.Entity<Food>().HasData(CreateFood(21, "Iskender Kebab", 151, 16, 6, 10, 9));
            modelBuilder.Entity<Food>().HasData(CreateFood(22, "Iceberg Lettuce Salad", 54, 5, 4, 1, 11));
            modelBuilder.Entity<Food>().HasData(CreateFood(23, "Caesar Salad", 128, 7, 5, 14, 11));
            modelBuilder.Entity<Food>().HasData(CreateFood(24, "Feta Cheese", 310, 3, 25, 21, 12));
            modelBuilder.Entity<Food>().HasData(CreateFood(25, "Olive", 207, 2, 21, 2, 12));
            modelBuilder.Entity<Food>().HasData(CreateFood(26, "Bread", 256, 53, 1, 8, 13));
            modelBuilder.Entity<Food>().HasData(CreateFood(27, "Wholewheat Bread", 216, 45, 2, 6, 13));

            

            modelBuilder.Entity<User>().HasData(CreateUser(1,"admin", "admin", "admin@", "adminSecurityQuestion", "adminSecurityAnswer",true));

        }
        
        //protected override void Seed()
        //{
        //    // Seed data ekleme işlemleri
        //    CreateFood("Cola", 37, 10, 0, 0,1);
        //}

        public Food CreateFood(int foodID,string foodName, double foodCal, int foodCarb, int foodFat, int foodProt, int categoryID)
        {
            var food = new Food
            {
                FoodID= foodID,
                FoodName = foodName,
                FoodCal = foodCal,
                FoodCarb = foodCarb,
                FoodFat = foodFat,
                FoodProt = foodProt,
                CategoryId = categoryID,
            };
            return food;
        }

        public User CreateUser(int userID,string name, string password, string email, string securityQuestion, string securityAnswer, bool isAdmin)
        {

            User user = new User
            {
                UserID= userID,
                UserName = name,
                Password = password,
                Email = email,
                SecurityQuestion = securityQuestion,
                SecurityAnswer = securityAnswer,
                IsAdmin = true
                    
            };
                return user;
        }

        public Category CreateCategory(int categoryID,string categoryName)
        {
            Category category = new Category
            {
                CategoryId= categoryID,
                CategoryName = categoryName,
            };
            return category;
        }

    }
}
