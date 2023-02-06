using CalCalculatorDAL;
using CalCalculatorDAL.Repositories;
using CalCalculatorEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculatorBLL
{
    public class CategoryServices:BaseRepository<Category>
    {
        CalCalculateDB _db;
        int categoryId;
        public void CreateDefaultCategoriesIfNotExist() //Default yemek kategorileri eğer databasede yoksa database'e ekleyen metot.
        {
            using (_db = new CalCalculateDB())
            {
                CreateCategoryIfNotExist("Desserts");
                CreateCategoryIfNotExist("Drinks");
                CreateCategoryIfNotExist("Sea Foods");
                CreateCategoryIfNotExist("Pastries");
                CreateCategoryIfNotExist("Fast Foods");
                CreateCategoryIfNotExist("Fruits");
                CreateCategoryIfNotExist("Vegetable");
                CreateCategoryIfNotExist("Snacks");
                CreateCategoryIfNotExist("Kebabs");
                CreateCategoryIfNotExist("Legumes");
                CreateCategoryIfNotExist("Salads");
                CreateCategoryIfNotExist("Breakfast Foods");
                CreateCategoryIfNotExist("Bakery");
            }
        }
        public void CreateCategoryIfNotExist(string categoryName)
        {
            using (_db = new CalCalculateDB())
            {
                if (!_db.Categories.Select(x => x.CategoryName).Contains(categoryName))
                {
                        Category category = new Category
                        {
                            CategoryName = categoryName,
                        };
                        AddEntity(category);
                   
                }
            }
            
        }

        public List<string> BringCategoryNames()
        {
            List<string> categoryNames = new List<string>();
            categoryNames = QueryableList().Select(x => x.CategoryName).ToList();
            return categoryNames;
        }
        public CategoryServices()
        {

        }
        public CategoryServices(Category category)
        {
            categoryId = category.CategoryId;
        }
        public IList<Category> SearchCategoryByName(string categoryName)
        {
            using (_db = new CalCalculateDB())
            {
                return _db.Categories.Where(x => x.CategoryName == categoryName).ToList();
            }
                
        }

    }
}




