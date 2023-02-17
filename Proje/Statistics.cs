using CalCalculatorDAL;
using CalCalculatorEntities;
using CalCalculatorEntities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace Proje
{
    public partial class Statistics : Form
    {
        CalCalculateDB _db;
        User user;


        public Statistics(User currentUser)
        {
            user = currentUser;
            InitializeComponent();
        }

        private void btn_Getir_Click(object sender, EventArgs e)
        {
            using (_db = new())
            {
                //if (rdnToplamCal.Checked == true)
                //{
                //    /// user'ın meal listesine ulaş 
                //    /// tarihe göre ayıkla(Created Time)
                //    /// 
                //    double TopCal = 0;
                //    //var sonuc = user.Meals.Where(x => x.CreateTime <= dtpEndDate.Value && x.CreateTime>=dtpStartDate.Value).ToList();
                //    List<Meal> selectedMeals = _db.Meals.Where(x => x.CreateTime.Day <= dtpEndDate.Value.Day && x.CreateTime.Day >= dtpStartDate.Value.Day && x.ContactUserID == user.UserID).ToList();

                //    foreach (Meal item in selectedMeals)
                //    {
                //        TopCal = item.TotalCalorie + TopCal;
                //    }

                //    txtTopcal.Text = TopCal.ToString();
                //}


                if (rdnCategories.Checked == true)
                {
                    TempCategoryStatistics temp = new();

                    List<Meal> mealList = _db.Meals.Where(x => x.CreateTime.Day <= dtpEndDate.Value.Day && x.CreateTime.Day >= dtpStartDate.Value.Day && x.ContactUserID == user.UserID).ToList();

                    DateTime startDate = new DateTime(2023, 2, 1);
                    DateTime endDate = new DateTime(2023, 2, 20);

                    var categoryCalories = from meal in _db.Meals
                                           where meal.CreateTime >= startDate && meal.CreateTime <= endDate
                                           join foodMeal in _db.FoodMeals on meal.MealID equals foodMeal.MealID
                                           join food in _db.Foods on foodMeal.FoodID equals food.FoodID
                                           join category in _db.Categories on food.CategoryId equals category.CategoryId
                                           group foodMeal by category.CategoryName into g
                                           select new {
                                               Category = g.Key,
                                               //TotalCalories = g.Sum(f => f.FoodCal * (_db.FoodMeals.Where(x => x.FoodID == f.FoodID).FirstOrDefault().Grams)) 
                                               kalori = g.Sum(x=>x.Grams/100*(x.Food.FoodCal))
                       };

                    dgvStatisticsTabşe.DataSource= categoryCalories.ToList();

                }


            }
        }

    }
}
