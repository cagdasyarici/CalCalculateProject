using CalCalculatorDAL.Configuration;
using CalCalculatorEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
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
        //public DbSet<Image> Images { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //DENİZ


            //optionsBuilder.UseSqlServer("Server=DENIZ;Database=CalCalculateDB;Trusted_Connection=True");



            //ÇAĞDAŞ

            //optionsBuilder.UseSqlServer("server=chado\\mssqlkd14;database=calcalculatedb8;trusted_connection=true");


            //YUŞA

            optionsBuilder.UseSqlServer("Server=YUSATOSUN\\SQLEXPRESS;Database=CalCalculateDB;Trusted_Connection=True;");
        }
        //public class Image
        //{
        //    public int Id { get; set; }
        //    public byte[] ImageData { get; set; }
        //}

        #region Localden Fotoğraf Alma
        //public byte[] GetImageData(string imagePath)
        //{
        //    using (FileStream fileStream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
        //    {
        //        using (MemoryStream memoryStream = new MemoryStream())
        //        {
        //            fileStream.CopyTo(memoryStream);
        //            return memoryStream.ToArray();
        //        }
        //    }
        //}
        #endregion

        #region Internetten Fotoğraf Alma
        //public byte[] GetImageDataFromWeb(string imageUrl)
        //{
        //    var webClient = new WebClient();
        //    byte[] imageData = webClient.DownloadData(imageUrl); // resmin binary verisi
        //    return imageData;
        //}
        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            #region Seed Data



            modelBuilder.Entity<Category>().HasData(CreateCategory(1, "Desserts"));
            modelBuilder.Entity<Category>().HasData(CreateCategory(2, "Drinks"));
            modelBuilder.Entity<Category>().HasData(CreateCategory(3, "Sea Foods"));
            modelBuilder.Entity<Category>().HasData(CreateCategory(4, "Pastries"));
            modelBuilder.Entity<Category>().HasData(CreateCategory(5, "Fast Foods"));
            modelBuilder.Entity<Category>().HasData(CreateCategory(6, "Fruits"));
            modelBuilder.Entity<Category>().HasData(CreateCategory(7, "Vegetable"));
            modelBuilder.Entity<Category>().HasData(CreateCategory(8, "Snacks"));
            modelBuilder.Entity<Category>().HasData(CreateCategory(9, "Kebabs"));
            modelBuilder.Entity<Category>().HasData(CreateCategory(10, "Legumes"));
            modelBuilder.Entity<Category>().HasData(CreateCategory(11, "Salads"));
            modelBuilder.Entity<Category>().HasData(CreateCategory(12, "Breakfast Foods"));
            modelBuilder.Entity<Category>().HasData(CreateCategory(13, "Bakery"));
            #region Fotoğraf Ekleme Şuanlık tam çalışmıyor
            modelBuilder.Entity<Food>().HasData(CreateFood(1, "Coke", 37, 10, 0, 0, 2));
            modelBuilder.Entity<Food>().HasData(CreateFood(2, "Juice", 54, 13, 0, 0, 2));
            modelBuilder.Entity<Food>().HasData(CreateFood(3, "Tea", 1, 0, 0, 0, 2));
            modelBuilder.Entity<Food>().HasData(CreateFood(4, "Coffee", 1, 0, 0, 0, 2));
            modelBuilder.Entity<Food>().HasData(CreateFood(5, "Soda", 95, 24, 0, 0, 2));
            modelBuilder.Entity<Food>().HasData(CreateFood(6, "Turkish Delight", 359, 90, 0, 0, 1));
            modelBuilder.Entity<Food>().HasData(CreateFood(7, "Baklava", 428, 38, 29, 7, 1));
            modelBuilder.Entity<Food>().HasData(CreateFood(8, "Kazandibi", 130, 20, 4, 3, 1));
            modelBuilder.Entity<Food>().HasData(CreateFood(9, "Caramel Waffle", 452, 62, 21, 3, 1));
            modelBuilder.Entity<Food>().HasData(CreateFood(10, "Profiterole", 429, 56, 20, 6, 1));
            modelBuilder.Entity<Food>().HasData(CreateFood(11, "Bonito", 216, 0, 15, 20, 3));
            modelBuilder.Entity<Food>().HasData(CreateFood(12, "Red Mullet", 124, 0, 3, 20, 3));
            modelBuilder.Entity<Food>().HasData(CreateFood(13, "Bream", 96, 0, 2, 20, 3));
            modelBuilder.Entity<Food>().HasData(CreateFood(14, "Octopus", 164, 5, 2, 30, 3));
            modelBuilder.Entity<Food>().HasData(CreateFood(15, "Moules Provencales", 89, 3, 5, 8, 3));
            modelBuilder.Entity<Food>().HasData(CreateFood(16, "Chocolate Cake", 385, 27, 29, 5, 4));
            modelBuilder.Entity<Food>().HasData(CreateFood(17, "Fruit Cake", 172, 27, 5, 4, 4));
            modelBuilder.Entity<Food>().HasData(CreateFood(18, "Burger", 165, 20, 6, 7, 5));
            modelBuilder.Entity<Food>().HasData(CreateFood(19, "Pizza", 186, 31, 5, 6, 5));
            modelBuilder.Entity<Food>().HasData(CreateFood(20, "Hotdog", 253, 28, 12, 9, 5));
            modelBuilder.Entity<Food>().HasData(CreateFood(21, "Doner", 128, 9, 20, 9, 5));
            modelBuilder.Entity<Food>().HasData(CreateFood(22, "Fried Potatoes", 280, 37, 13, 4, 5));
            modelBuilder.Entity<Food>().HasData(CreateFood(23, "Apple", 56, 14, 1, 1, 6));
            modelBuilder.Entity<Food>().HasData(CreateFood(24, "Melon", 28, 7, 1, 1, 6));
            modelBuilder.Entity<Food>().HasData(CreateFood(25, "Watermelon", 100, 25, 1, 0, 6));
            modelBuilder.Entity<Food>().HasData(CreateFood(26, "Grape", 69, 18, 0, 1, 6));
            modelBuilder.Entity<Food>().HasData(CreateFood(27, "Fig", 74, 19, 0, 1, 6));
            modelBuilder.Entity<Food>().HasData(CreateFood(28, "Cauliflower", 24, 5, 2, 1, 7));
            modelBuilder.Entity<Food>().HasData(CreateFood(29, "Eggplant", 17, 3, 0, 2, 7));
            modelBuilder.Entity<Food>().HasData(CreateFood(30, "Broccoli", 26, 3, 0, 4, 7));
            modelBuilder.Entity<Food>().HasData(CreateFood(31, "Artichoke", 53, 12, 1, 3, 7));
            modelBuilder.Entity<Food>().HasData(CreateFood(32, "Fried Cabbage", 226, 2, 25, 2, 7));
            modelBuilder.Entity<Food>().HasData(CreateFood(33, "Corn Chips", 539, 57, 35, 7, 8));
            modelBuilder.Entity<Food>().HasData(CreateFood(34, "Potato Chips", 532, 8, 56, 1, 8));
            modelBuilder.Entity<Food>().HasData(CreateFood(35, "Oreos", 474, 72, 4, 19, 8));
            modelBuilder.Entity<Food>().HasData(CreateFood(36, "Popcorn", 525, 40, 37, 7, 8));
            modelBuilder.Entity<Food>().HasData(CreateFood(37, "Jelly Bears", 335, 76, 0, 7, 8));
            modelBuilder.Entity<Food>().HasData(CreateFood(38, "Adana Kebab", 239, 1, 20, 14, 9));
            modelBuilder.Entity<Food>().HasData(CreateFood(39, "Iskender Kebab", 151, 16, 6, 10, 9));
            modelBuilder.Entity<Food>().HasData(CreateFood(40, "Chicken Kebab", 141, 12, 1, 21, 9));
            modelBuilder.Entity<Food>().HasData(CreateFood(41, "Iceberg Lettuce Salad", 54, 5, 4, 1, 11));
            modelBuilder.Entity<Food>().HasData(CreateFood(42, "Caesar Salad", 128, 7, 5, 14, 11));
            modelBuilder.Entity<Food>().HasData(CreateFood(43, "Feta Cheese", 310, 3, 25, 21, 12));
            modelBuilder.Entity<Food>().HasData(CreateFood(44, "Olive", 207, 2, 21, 2, 12));
            modelBuilder.Entity<Food>().HasData(CreateFood(45, "Cereal", 378, 81, 2, 7, 12));
            modelBuilder.Entity<Food>().HasData(CreateFood(46, "French Toast", 229, 25, 11, 8, 12));
            modelBuilder.Entity<Food>().HasData(CreateFood(47, "Bread", 256, 53, 1, 8, 13));
            modelBuilder.Entity<Food>().HasData(CreateFood(48, "Wholewheat Bread", 216, 45, 2, 6, 13));
            modelBuilder.Entity<Food>().HasData(CreateFood(49, "Bagel", 275, 58, 4, 10, 13));
            modelBuilder.Entity<Food>().HasData(CreateFood(50, "Savory Bun", 275, 58, 4, 10, 13));

            #endregion

            modelBuilder.Entity<User>().HasData(CreateUser(1, "admin", "admin", "admin@", "adminSecurityQuestion", "adminSecurityAnswer", true));
            #endregion
        }

        //protected override void Seed()
        //{
        //    // Seed data ekleme işlemleri
        //    CreateFood("Cola", 37, 10, 0, 0,1);
        //}

        public Food CreateFood(int foodID, string foodName, double foodCal, int foodCarb, int foodFat, int foodProt, int categoryID)
        {
            var food = new Food
            {
                FoodID = foodID,
                FoodName = foodName,
                FoodCal = foodCal,
                FoodCarb = foodCarb,
                FoodFat = foodFat,
                FoodProt = foodProt,
                CategoryId = categoryID,
            };
            return food;
        }
        public Food CreateFood(int foodID, string foodName, double foodCal, int foodCarb, int foodFat, int foodProt, int categoryID, byte[] photo)
        {
            var food = new Food
            {
                FoodID = foodID,
                FoodName = foodName,
                FoodCal = foodCal,
                FoodCarb = foodCarb,
                FoodFat = foodFat,
                FoodProt = foodProt,
                CategoryId = categoryID,
                Photo = photo
            };
            return food;
        }

        public User CreateUser(int userID, string name, string password, string email, string securityQuestion, string securityAnswer, bool isAdmin)
        {

            User user = new User
            {
                UserID = userID,
                UserName = name,
                Password = password,
                Email = email,
                SecurityQuestion = securityQuestion,
                SecurityAnswer = securityAnswer,
                IsAdmin = true

            };
            return user;
        }
        //public User CreateUser(int userID, string name, string password, string email, string securityQuestion, string securityAnswer, bool isAdmin, byte[] photo)
        //{

        //    User user = new User
        //    {
        //        UserID = userID,
        //        UserName = name,
        //        Password = password,
        //        Email = email,
        //        SecurityQuestion = securityQuestion,
        //        SecurityAnswer = securityAnswer,
        //        IsAdmin = true,
        //        Photo = photo
        //    };
        //    return user;
        //}
        public Category CreateCategory(int categoryID, string categoryName)
        {
            Category category = new Category
            {
                CategoryId = categoryID,
                CategoryName = categoryName,
            };
            return category;
        }

    }
}
