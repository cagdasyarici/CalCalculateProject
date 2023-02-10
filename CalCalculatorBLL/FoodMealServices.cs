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
    public class FoodMealServices : BaseRepository<FoodMeal>
    {
        CalCalculateDB _db;
        public FoodMeal FindFoodMeal(int foodId, int mealId)
        {
            using (_db = new CalCalculateDB())
            {
                return _db.FoodMeals.Where(x => x.FoodID == foodId && x.MealID == mealId).FirstOrDefault();
            }
        }
    }
}
