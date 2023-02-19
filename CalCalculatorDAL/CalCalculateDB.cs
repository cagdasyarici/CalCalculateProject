using CalCalculatorDAL.Configuration;
using CalCalculatorEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
        public DbSet<Image> Images { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //DENİZ


            optionsBuilder.UseSqlServer("Server=DENIZ;Database=CalCalculateDB;Trusted_Connection=True");



            //ÇAĞDAŞ

            optionsBuilder.UseSqlServer("Server=CHADO\\MSSQLKD14;Database=CalCalculateDB8;Trusted_Connection=True");


            //YUŞA

            //optionsBuilder.UseSqlServer("Server=YUSATOSUN\\SQLEXPRESS;Database=CalCalculateDB;Trusted_Connection=True;");
        }
        public class Image
        {
            public int Id { get; set; }
            public byte[] ImageData { get; set; }
        }

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
        public byte[] GetImageDataFromWeb(string imageUrl)
        {
            var webClient = new WebClient();
            byte[] imageData = webClient.DownloadData(imageUrl); // resmin binary verisi
            return imageData;
        }
        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfigurations()).ApplyConfiguration(new MealConfiguration())
                .ApplyConfiguration(new FoodMealConfigurations());
            base.OnModelCreating(modelBuilder);
            #region Seed Data



            byte[] userImage = GetImageDataFromWeb("https://as1.ftcdn.net/v2/jpg/00/64/67/52/1000_F_64675209_7ve2XQANuzuHjMZXP3aIYIpsDKEbF5dD.jpg");
            

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

            modelBuilder.Entity<Food>().HasData(CreateFood(1, "Coke", 37, 10, 0, 0, 2, GetImageDataFromWeb("https://images.pexels.com/photos/2983100/pexels-photo-2983100.jpeg")));
            modelBuilder.Entity<Food>().HasData(CreateFood(2, "Juice", 54, 13, 0, 0, 2, GetImageDataFromWeb("https://images.pexels.com/photos/96974/pexels-photo-96974.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1")));
            modelBuilder.Entity<Food>().HasData(CreateFood(3, "Tea", 1, 0, 0, 0, 2, GetImageDataFromWeb("https://images.pexels.com/photos/1493079/pexels-photo-1493079.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1")));
            modelBuilder.Entity<Food>().HasData(CreateFood(4, "Coffee", 1, 0, 0, 0, 2, GetImageDataFromWeb("https://images.pexels.com/photos/1727123/pexels-photo-1727123.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1")));
            modelBuilder.Entity<Food>().HasData(CreateFood(5, "Soda", 95, 24, 0, 0, 2, GetImageDataFromWeb("https://images.pexels.com/photos/6489668/pexels-photo-6489668.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1")));
            modelBuilder.Entity<Food>().HasData(CreateFood(6, "Turkish Delight", 359, 90, 0, 0, 1, GetImageDataFromWeb("https://images.pexels.com/photos/9923741/pexels-photo-9923741.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1")));
            modelBuilder.Entity<Food>().HasData(CreateFood(7, "Baklava", 428, 38, 29, 7, 1, GetImageDataFromWeb("https://images.pexels.com/photos/5323489/pexels-photo-5323489.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1")));
            modelBuilder.Entity<Food>().HasData(CreateFood(8, "Kazandibi", 130, 20, 4, 3, 1, GetImageDataFromWeb("https://images.pexels.com/photos/302468/pexels-photo-302468.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1")));
            modelBuilder.Entity<Food>().HasData(CreateFood(9, "Caramel Waffle", 452, 62, 21, 3, 1, GetImageDataFromWeb("https://images.pexels.com/photos/1914831/pexels-photo-1914831.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1")));
            modelBuilder.Entity<Food>().HasData(CreateFood(10, "Profiterole", 429, 56, 20, 6, 1, GetImageDataFromWeb("https://images.pexels.com/photos/13525003/pexels-photo-13525003.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1")));
            modelBuilder.Entity<Food>().HasData(CreateFood(11, "Bonito", 216, 0, 15, 20, 3, GetImageDataFromWeb("https://images.pexels.com/photos/8963384/pexels-photo-8963384.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1")));
            modelBuilder.Entity<Food>().HasData(CreateFood(12, "Red Mullet", 124, 0, 3, 20, 3, GetImageDataFromWeb("https://images.pexels.com/photos/1321124/pexels-photo-1321124.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1")));
            modelBuilder.Entity<Food>().HasData(CreateFood(13, "Bream", 96, 0, 2, 20, 3, GetImageDataFromWeb("https://images.pexels.com/photos/262959/pexels-photo-262959.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1")));
            modelBuilder.Entity<Food>().HasData(CreateFood(14, "Octopus", 164, 5, 2, 30, 3, GetImageDataFromWeb("https://images.pexels.com/photos/10432639/pexels-photo-10432639.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1")));
            modelBuilder.Entity<Food>().HasData(CreateFood(15, "Moules Provencales", 89, 3, 5, 8, 3));
            modelBuilder.Entity<Food>().HasData(CreateFood(16, "Chocolate Cake", 385, 27, 29, 5, 4, GetImageDataFromWeb("https://images.pexels.com/photos/1854652/pexels-photo-1854652.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1")));
            modelBuilder.Entity<Food>().HasData(CreateFood(17, "Fruit Cake", 172, 27, 5, 4, 4, GetImageDataFromWeb("https://images.pexels.com/photos/461431/pexels-photo-461431.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1")));
            modelBuilder.Entity<Food>().HasData(CreateFood(18, "Burger", 165, 20, 6, 7, 5, GetImageDataFromWeb("https://images.pexels.com/photos/1639557/pexels-photo-1639557.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1")));
            //modelBuilder.Entity<Food>().HasData(CreateFood(19, "Pizza", 186, 31, 5, 6, 5, GetImageDataFromWeb("https://www.kevserinmutfagi.com/wp-content/uploads/2016/02/karisik_pizza1-600x450.jpg")));
            //modelBuilder.Entity<Food>().HasData(CreateFood(20, "Hotdog", 253, 28, 12, 9, 5, GetImageDataFromWeb("https://i0.wp.com/blog.blueapron.com/wp-content/uploads/2022/07/loaded-hot-dogs.jpg?resize=620%2C620&ssl=1")));
            //modelBuilder.Entity<Food>().HasData(CreateFood(21, "Doner", 128, 9, 20, 9, 5, GetImageDataFromWeb("https://tunafood.com/wp-content/uploads/2020/09/755_tavuk_doner.png")));
            //modelBuilder.Entity<Food>().HasData(CreateFood(22, "Fried Potatoes", 280, 37, 13, 4, 5, GetImageDataFromWeb("https://png.pngtree.com/png-vector/20210415/ourmid/pngtree-snacks-fried-potato-strips-png-image_3219785.jpg")));
            //modelBuilder.Entity<Food>().HasData(CreateFood(23, "Apple", 56, 14, 1, 1, 6, GetImageDataFromWeb("https://png.pngtree.com/element_our/png/20181129/vector-illustration-of-fresh-red-apple-with-single-leaf-png_248312.jpg")));
            //modelBuilder.Entity<Food>().HasData(CreateFood(24, "Melon", 28, 7, 1, 1, 6, GetImageDataFromWeb("https://www.agroponiente.com/wp-content/uploads/2021/09/melon-amarillo-Agroponiente.png")));
            //modelBuilder.Entity<Food>().HasData(CreateFood(25, "Watermelon", 100, 25, 1, 0, 6, GetImageDataFromWeb("https://play-lh.googleusercontent.com/3vS4HgaeuFnDnuxq9UWgLF5h8e0nxTfuySDfk1JzI0t13FoJteTDwz1ujzwHb8amEPZo")));
            //modelBuilder.Entity<Food>().HasData(CreateFood(26, "Grape", 69, 18, 0, 1, 6, GetImageDataFromWeb("http://s3.amazonaws.com/pix.iemoji.com/images/emoji/apple/ios-12/256/grapes.png")));
            //modelBuilder.Entity<Food>().HasData(CreateFood(27, "Fig", 74, 19, 0, 1, 6, GetImageDataFromWeb("https://www.daleeeel.com/f/res/s05/products-photos/000/030/0003054-377-rinnoo-0bc31c4d0900411b83c23097709fee5a-r00.jpg")));
            //modelBuilder.Entity<Food>().HasData(CreateFood(28, "Cauliflower", 24, 5, 2, 1, 7, GetImageDataFromWeb("https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/roasted-cauliflower-copy-1648147911.jpeg")));
            //modelBuilder.Entity<Food>().HasData(CreateFood(29, "Eggplant", 17, 3, 0, 2, 7, GetImageDataFromWeb("https://feelingfoodish.com/wp-content/uploads/2017/09/twice-cooked-eggplant-israeli.jpg")));
            //modelBuilder.Entity<Food>().HasData(CreateFood(30, "Broccoli", 26, 3, 0, 4, 7, GetImageDataFromWeb("https://i.pinimg.com/474x/f4/4f/b1/f44fb144c798b9a509009b03675d2fab.jpg")));
            //modelBuilder.Entity<Food>().HasData(CreateFood(31, "Artichoke", 53, 12, 1, 3, 7, GetImageDataFromWeb("https://www.savorytooth.com/wp-content/uploads/2016/03/artichoke-square3.jpg")));
            //modelBuilder.Entity<Food>().HasData(CreateFood(32, "Fried Cabbage", 226, 2, 25, 2, 7, GetImageDataFromWeb("https://i.pinimg.com/originals/00/75/ed/0075ed85439cd9a3857cfe63bc613273.jpg")));
            //modelBuilder.Entity<Food>().HasData(CreateFood(33, "Corn Chips", 539, 57, 35, 7, 8, GetImageDataFromWeb("https://m.media-amazon.com/images/I/71qpgilWoZL._CR0,559,961,961_UX256.jpg")));
            //modelBuilder.Entity<Food>().HasData(CreateFood(34, "Potato Chips", 532, 8, 56, 1, 8, GetImageDataFromWeb("https://upload.wikimedia.org/wikipedia/commons/thumb/6/69/Potato-Chips.jpg/800px-Potato-Chips.jpg")));
            //modelBuilder.Entity<Food>().HasData(CreateFood(35, "Oreos", 474, 72, 4, 19, 8, GetImageDataFromWeb("https://a.wattpad.com/useravatar/IHazOreo.256.483192.jpg")));
            //modelBuilder.Entity<Food>().HasData(CreateFood(36, "Popcorn", 525, 40, 37, 7, 8, GetImageDataFromWeb("https://productimages.hepsiburada.net/s/75/375/110000016550244.jpg")));
            //modelBuilder.Entity<Food>().HasData(CreateFood(37, "Jelly Bears", 335, 76, 0, 7, 8, GetImageDataFromWeb("https://styles.redditmedia.com/t5_cknms/styles/communityIcon_9p8rr1gbi4x81.png")));
            //modelBuilder.Entity<Food>().HasData(CreateFood(38, "Adana Kebab", 239, 1, 20, 14, 9, GetImageDataFromWeb("https://www.pngmart.com/files/21/Adana-Kebab-PNG-Image.png")));
            //modelBuilder.Entity<Food>().HasData(CreateFood(39, "Iskender Kebab", 151, 16, 6, 10, 9, GetImageDataFromWeb("https://media-cdn.tripadvisor.com/media/photo-s/0d/e0/d1/fa/iskender-kebab.jpg")));
            //modelBuilder.Entity<Food>().HasData(CreateFood(40, "Chicken Kebab", 141, 12, 1, 21, 9, GetImageDataFromWeb("https://www.pngarts.com/files/8/Chicken-Kebab-PNG-Image-Background.png")));
            //modelBuilder.Entity<Food>().HasData(CreateFood(41, "Iceberg Lettuce Salad", 54, 5, 4, 1, 11, GetImageDataFromWeb("https://png.pngtree.com/png-vector/20210108/ourlarge/pngtree-cucumber-lettuce-still-life-photography-salad-png-image_2696609.jpg")));
            //modelBuilder.Entity<Food>().HasData(CreateFood(42, "Caesar Salad", 128, 7, 5, 14, 11, GetImageDataFromWeb("https://freepngimg.com/thumb/salad/34916-3-grilled-chicken-caesar-salad.png")));
            //modelBuilder.Entity<Food>().HasData(CreateFood(43, "Feta Cheese", 310, 3, 25, 21, 12, GetImageDataFromWeb("https://e7.pngegg.com/pngimages/204/175/png-clipart-tofu-and-mint-feta-milk-greek-cuisine-goat-cheese-milk-food-recipe-thumbnail.png")));
            //modelBuilder.Entity<Food>().HasData(CreateFood(44, "Olive", 207, 2, 21, 2, 12, GetImageDataFromWeb("https://img.freepik.com/free-photo/green-olives-oil_144627-26921.jpg")));
            //modelBuilder.Entity<Food>().HasData(CreateFood(45, "Cereal", 378, 81, 2, 7, 12, GetImageDataFromWeb("http://atlas-content-cdn.pixelsquid.com/stock-images/bowl-of-cereal-with-spoon-Je1YxvB-600.jpg")));
            //modelBuilder.Entity<Food>().HasData(CreateFood(46, "French Toast", 229, 25, 11, 8, 12, GetImageDataFromWeb("https://i.pinimg.com/474x/03/88/37/0388374f4fc638265f2f537e51f98abb.jpg")));
            //modelBuilder.Entity<Food>().HasData(CreateFood(47, "Bread", 256, 53, 1, 8, 13, GetImageDataFromWeb("https://w7.pngwing.com/pngs/954/1001/png-transparent-white-bread-bread-baked-goods-food-whole-grain-thumbnail.png")));
            //modelBuilder.Entity<Food>().HasData(CreateFood(48, "Wholewheat Bread", 216, 45, 2, 6, 13, GetImageDataFromWeb("https://toppng.com/uploads/preview/bread-whole-wheat-bread-11563249870kvmr4u7iop.png")));
            //modelBuilder.Entity<Food>().HasData(CreateFood(49, "Bagel", 275, 58, 4, 10, 13, GetImageDataFromWeb("https://www.pngmart.com/files/17/Sweet-Bagel-PNG-Photos.png")));
            //modelBuilder.Entity<Food>().HasData(CreateFood(50, "Savory Bun", 275, 58, 4, 10, 13, GetImageDataFromWeb("https://j4c7s4z9.rocketcdn.me/icerik/uploads/2020/10/acma-300x225.png")));

            modelBuilder.Entity<User>().HasData(CreateUser(1, "admin", "admin", "admin@", "adminSecurityQuestion", "adminSecurityAnswer", true, userImage));
            #endregion
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
                Photo= photo
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
        public User CreateUser(int userID, string name, string password, string email, string securityQuestion, string securityAnswer, bool isAdmin, byte[] photo)
        {

            User user = new User
            {
                UserID = userID,
                UserName = name,
                Password = password,
                Email = email,
                SecurityQuestion = securityQuestion,
                SecurityAnswer = securityAnswer,
                IsAdmin = true,
                Photo = photo
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
