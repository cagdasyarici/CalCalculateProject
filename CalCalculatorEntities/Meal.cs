using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculatorEntities
{
    public class Meal
    {
        public int MealID { get; set; }
        public string MealName { get; set; }
        public int ContactUserID { get; set; }
        public virtual User User { get; set; }
        public DateTime CreateTime { get; set; }
        public double TotalCalorie { get; set; }
        public virtual ICollection<FoodMeal> FoodMeals { get; set; }
        public Meal()
        {
            FoodMeals = new List<FoodMeal>();
        }
    }
}
