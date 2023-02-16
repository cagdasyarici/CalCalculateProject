using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculatorEntities
{
    public class FoodMeal
    {
        public int FoodID { get; set; }
        public virtual Food Food { get; set; }
        public int MealID { get; set; }
        public virtual Meal Meal { get; set; }
        public double Grams { get; set; }
    }
}
