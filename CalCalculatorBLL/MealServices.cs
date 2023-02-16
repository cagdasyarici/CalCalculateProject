using CalCalculatorDAL;
using CalCalculatorDAL.Repositories;
using CalCalculatorEntities;
using CalCalculatorEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculatorBLL
{
    public class MealServices : BaseRepository<Meal>
    {
        CalCalculateDB _db;
        public void CreateMeal(string mealName, int userId)
        {
            using (_db = new CalCalculateDB())
            {
                Meal meal = new Meal
                {
                    MealName = mealName,
                    ContactUserID = userId,
                    CreateTime = DateTime.Now,
                };
                MealServices mealServices = new MealServices();
                mealServices.AddEntity(meal);
            }

        }
        public List<Meal> SearchByDate(DateTime date, User user)
        {
            return QueryableList().Where(x => x.CreateTime.Date == date.Date && x.ContactUserID == user.UserID).ToList();
        }

        public List<Meal> SearchByDate(DateTime date1, DateTime date2, User user)
        {

            if (date1 > date2)
            {
                return QueryableList().Where(x => x.CreateTime.Date >= date2.Date && x.CreateTime.Date <= date1 && x.ContactUserID == user.UserID).ToList();
            }
            else if (date1 < date2)
            {
                return QueryableList().Where(x => x.CreateTime.Date >= date1.Date && x.CreateTime.Date <= date2 && x.ContactUserID == user.UserID).ToList();
            }
            else
            {
                return QueryableList().Where(x => x.CreateTime.Date == date1.Date && x.CreateTime.Date == date2 && x.ContactUserID == user.UserID).ToList();
            }


        }

        /// <summary>
        /// Parametre olarak aldığı Meal'ın Food'larını listeler 
        /// </summary>
        /// <param name="meal"></param>
        /// <returns>TempFood Listesi tipinde geriye değer döndürür </returns>
        public List<TempFood> ListeOlustur(Meal meal)
        {
            using (_db = new CalCalculateDB())
            {

                return _db.FoodMeals.Where(x => x.MealID == meal.MealID).Select(x=>
                
                new TempFood
                {
                    FoodName = x.Food.FoodName,
                    Calories = x.Food.FoodCal * (x.Grams / 100),
                    Grams = x.Grams,
                    FoodID = x.FoodID
                }
                ).ToList();

            }
        }


    }
}
