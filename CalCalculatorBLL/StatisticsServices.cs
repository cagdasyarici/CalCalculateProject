using CalCalculatorDAL;
using CalCalculatorEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CalCalculatorBLL
{
    public class StatisticsServices
    {
        CalCalculateDB _db;
  
        public dynamic DailyReport(User user)
        {
            using (_db = new())
            {

                #region ESKİ
                //var totalCalList = from meal in _db.Meals.Where(x => x.ContactUserID == user.UserID)
                //                   where meal.CreateTime.Day == DateTime.Now.Day
                //                   join foodMeal in _db.FoodMeals on meal.MealID equals foodMeal.MealID
                //                   join food in _db.Foods on foodMeal.FoodID equals food.FoodID
                //                   join category in _db.Categories on food.CategoryId equals category.CategoryId
                //                   group foodMeal by meal.MealName into g
                //                   orderby g.Sum(x => x.Grams) descending
                //                   select new
                //                   {
                //                       Meal = g.Key,
                //                       Calorie = g.Sum(x => x.Grams / 100 * x.Food.FoodCal)



                //                   };

                //dgvStatisticsTable.DataSource = totalCalList.ToList();
                #endregion

                var DailyReportList = from meal in _db.Meals
                                      where meal.CreateTime.Date == DateTime.Now.Date
                                      join foodMeal in _db.FoodMeals on meal.MealID equals foodMeal.MealID
                                      join food in _db.Foods on foodMeal.FoodID equals food.FoodID
                                      join category in _db.Categories on food.CategoryId equals category.CategoryId
                                      group foodMeal by meal.MealName into g
                                      select new
                                      {
                                          Meal = g.Key,
                                          Calorie = (int)g.Where(x => x.Meal.ContactUserID == user.UserID).Sum(x => x.Grams / 100 * (x.Food.FoodCal)),
                                          AvgCalories = (int)g.Sum(x => x.Grams / 100 * (x.Food.FoodCal)) / _db.Users.Count()


                                      };

                return DailyReportList.ToList();
            }



        }

        public dynamic WeeklyCompare(User user)
        {
            using (_db = new())
            {

                var WeeklyReportList = from meal in _db.Meals
                                       where meal.CreateTime.Date >= DateTime.Now.AddDays(-7).Date && meal.CreateTime.Date <= DateTime.Now.Date // todo:Burada date yapmaktan emin emin değilim
                                       join foodMeal in _db.FoodMeals on meal.MealID equals foodMeal.MealID
                                       join food in _db.Foods on foodMeal.FoodID equals food.FoodID
                                       join category in _db.Categories on food.CategoryId equals category.CategoryId
                                       group foodMeal by new { meal.MealName, food.FoodName } into g
                                       select new
                                       {
                                           Meal = g.Key.MealName,
                                           Food = g.Key.FoodName,
                                           Calorie = (int)g.Where(x => x.Meal.ContactUserID == user.UserID).Sum(x => x.Grams / 100 * (x.Food.FoodCal)),
                                           AvgCalories = (int)g.Sum(x => x.Grams / 100 * (x.Food.FoodCal)) / _db.Users.Count()


                                       };

                return WeeklyReportList.ToList();

            }
        }

        public dynamic MonthlyCompare(User user)
        {
            using (_db = new())
            {

                var MonthlyReportList = from meal in _db.Meals
                                        where meal.CreateTime.Month == DateTime.Now.Month
                                        join foodMeal in _db.FoodMeals on meal.MealID equals foodMeal.MealID
                                        join food in _db.Foods on foodMeal.FoodID equals food.FoodID
                                        join category in _db.Categories on food.CategoryId equals category.CategoryId
                                        group foodMeal by new { meal.MealName, food.FoodName } into g
                                        select new
                                        {
                                            Meal = g.Key.MealName,
                                            Food = g.Key.FoodName,
                                            Calorie = (int)g.Where(x => x.Meal.ContactUserID == user.UserID).Sum(x => x.Grams / 100 * (x.Food.FoodCal)),
                                            AvgCalories = (int)g.Sum(x => x.Grams / 100 * (x.Food.FoodCal)) / _db.Users.Count()

                                        };

                return MonthlyReportList.ToList();

            }



        }

        public dynamic GroupByFoodMeal(DateTime startDate,DateTime endDate,User user)
        {
            
            using (_db = new())
            {
                var List1 = from meal in _db.Meals.Where(x => x.ContactUserID == user.UserID)
                            where meal.CreateTime.Date >= startDate.Date && meal.CreateTime.Date <= endDate.Date
                            join foodMeal in _db.FoodMeals on meal.MealID equals foodMeal.MealID
                            join food in _db.Foods on foodMeal.FoodID equals food.FoodID
                            join category in _db.Categories on food.CategoryId equals category.CategoryId
                            group foodMeal by new { meal.MealName, food.FoodName } into g
                            select new
                            {
                                Meal = g.Key.MealName,
                                Food = g.Key.FoodName,
                                Grams = (int)g.Sum(x => x.Grams)

                            };



                return List1.ToList();
            }
        }
        
        public dynamic GroupByDate(DateTime startDate,DateTime endDate,User user)
        {



            using (_db = new())
            {
                var totalCalList = from meal in _db.Meals.Where(x => x.ContactUserID == user.UserID)
                                   where meal.CreateTime.Date >= startDate.Date && meal.CreateTime.Date <= endDate.Date
                                   join foodMeal in _db.FoodMeals on meal.MealID equals foodMeal.MealID
                                   join food in _db.Foods on foodMeal.FoodID equals food.FoodID
                                   join category in _db.Categories on food.CategoryId equals category.CategoryId
                                   group foodMeal by meal.CreateTime.Date into g
                                   select new
                                   {
                                       Date = g.Key,
                                       Calorie = (int)g.Sum(x => x.Grams / 100 * x.Food.FoodCal)



                                   };

                return totalCalList.ToList();
            }
        }

        public dynamic GroupByCategory(DateTime startDate, DateTime endDate, User user)
        {
            using (_db = new())
            {
                var categoryCalList = from meal in _db.Meals
                                      where meal.CreateTime.Date >= startDate.Date && meal.CreateTime.Date <= endDate.Date // todo: Date - Day kullanımına daha sonra bak 
                                      join foodMeal in _db.FoodMeals on meal.MealID equals foodMeal.MealID
                                      join food in _db.Foods on foodMeal.FoodID equals food.FoodID
                                      join category in _db.Categories on food.CategoryId equals category.CategoryId
                                      group foodMeal by category.CategoryName into g
                                      select new
                                      {
                                          Category = g.Key,
                                          Calorie = (int)g.Where(x => x.Meal.ContactUserID == user.UserID).Sum(x => x.Grams / 100 * (x.Food.FoodCal)),
                                          AvgCalories = (int)g.Sum(x => x.Grams / 100 * (x.Food.FoodCal)) / _db.Users.Count()


                                      };

                return categoryCalList.ToList();
            }
        }


    }
}
