using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculatorEntities
{
    public class Food
    {
        public int FoodID { get; set; }
        public string FoodName { get; set; }
        public int FoodCarb { get; set; }
        public int FoodFat { get; set; }
        public int FoodProt { get; set; }
        public double FoodCal { get; set; }
        public virtual ICollection<FoodMeal> FoodMeals { get; set; }
        public virtual Category Category { get; set; }
        public int CategoryId { get; set; }
        public Food()
        {
            FoodMeals = new List<FoodMeal>();
        }
    }
}
