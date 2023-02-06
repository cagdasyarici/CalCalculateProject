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
    public class MealServices:BaseRepository<Meal>
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
            return QueryableList().Where(x => x.CreateTime.Date == date.Date&&x.ContactUserID==user.UserID).ToList();
        }
    }
}
