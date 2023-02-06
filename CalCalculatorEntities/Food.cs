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
        public int FoodCal { get; set; }
        public int Grams { get; set; } // Her get edildiğinde Grams/100 ile değerleri çarpıp öyle getiririz. Ne kadar yediğiniz göstermiş oluruz.-DENİZ, ÇAĞDAŞ
        public virtual ICollection<FoodMeal> FoodMeals { get; set; }
        public virtual Category FoodCategory { get; set; }
        public int CategoryId { get; set; }
        public Food()
        {
            FoodMeals = new List<FoodMeal>();
        }
    }
}
