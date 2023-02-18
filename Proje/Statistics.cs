using CalCalculatorDAL;
using CalCalculatorEntities;
using CalCalculatorEntities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Proje
{
    public partial class Statistics : Form   // todo:Bu kısımdaki tarihleri tekrar gözden geçir
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
                DateTime startDate = dtpStartDate.Value;
                DateTime endDate = dtpEndDate.Value;


                if (rdnToplamCal.Checked == true)
                {
                    /// user'ın meal listesine ulaş 
                    /// tarihe göre ayıkla(Created Time)
                    /// 
                    #region ESKİ1
                    //double TopCal = 0;
                    ////var sonuc = user.Meals.Where(x => x.CreateTime <= dtpEndDate.Value && x.CreateTime>=dtpStartDate.Value).ToList();
                    //List<Meal> selectedMeals = _db.Meals.Where(x => x.CreateTime.Day <= dtpEndDate.Value.Day && x.CreateTime.Day >= dtpStartDate.Value.Day && x.ContactUserID == user.UserID).ToList();

                    //foreach (Meal item in selectedMeals)
                    //{
                    //    TopCal = item.TotalCalorie + TopCal;
                    //}

                    //txtTopcal.Text = TopCal.ToString(); 
                    #endregion

                    var totalCalList = from meal in _db.Meals.Where(x => x.ContactUserID == user.UserID)
                                       where meal.CreateTime.Day >= startDate.Day && meal.CreateTime.Day <= endDate.Day
                                       join foodMeal in _db.FoodMeals on meal.MealID equals foodMeal.MealID
                                       join food in _db.Foods on foodMeal.FoodID equals food.FoodID
                                       join category in _db.Categories on food.CategoryId equals category.CategoryId
                                       group foodMeal by meal.CreateTime.Date into g
                                       select new
                                       {
                                           Date = g.Key,
                                           Calorie = g.Sum(x => x.Grams / 100 * x.Food.FoodCal)



                                       };

                    dgvStatisticsTable.DataSource = totalCalList.ToList();


                }


                if (rdnCategories.Checked == true)
                {


                    var categoryCalList = from meal in _db.Meals
                                          where meal.CreateTime >= startDate && meal.CreateTime <= endDate
                                          join foodMeal in _db.FoodMeals on meal.MealID equals foodMeal.MealID
                                          join food in _db.Foods on foodMeal.FoodID equals food.FoodID
                                          join category in _db.Categories on food.CategoryId equals category.CategoryId
                                          group foodMeal by category.CategoryName into g
                                          select new
                                          {
                                              Category = g.Key,
                                              Calorie = g.Where(x => x.Meal.ContactUserID == user.UserID).Sum(x => x.Grams / 100 * (x.Food.FoodCal)),
                                              AvgCalories = g.Sum(x => x.Grams / 100 * (x.Food.FoodCal)) / _db.Users.Count()


                                          };

                    dgvStatisticsTable.DataSource = categoryCalList.ToList();



                    #region Eski1
                    //foreach (var item in TotalCalorieList)
                    //{
                    //    var AverageCaloryList = new
                    //    {
                    //        Category = item.Category,
                    //        Calories = item.Calories,
                    //        AvgCalories = item.Calories / (_db.Users.Count())


                    //    };
                    //}
                    //dgvStatisticsTable.DataSource = TotalCalorieList.ToList(); 
                    #endregion
                    #region ESKİ2
                    //var categoryCalories = from meal in _db.Meals.Where(x => x.ContactUserID == user.UserID)
                    //                       where meal.CreateTime >= startDate && meal.CreateTime <= endDate
                    //                       join foodMeal in _db.FoodMeals on meal.MealID equals foodMeal.MealID
                    //                       join food in _db.Foods on foodMeal.FoodID equals food.FoodID
                    //                       join category in _db.Categories on food.CategoryId equals category.CategoryId
                    //                       group foodMeal by category.CategoryName into g
                    //                       select new
                    //                       {
                    //                           Category = g.Key,  //todo: Aşırı önemli Nokta
                    //                           //TotalCalories = g.Sum(f => f.FoodCal * (_db.FoodMeals.Where(x => x.FoodID == f.FoodID).FirstOrDefault().Grams)) 
                    //                           Calories = g.Sum(x => x.Grams / 100 * (x.Food.FoodCal)),

                    //                       };

                    ////var categoryCaloriesList = categoryCalories.ToList();

                    //dgvStatisticsTable.DataSource = categoryCalories.ToList(); 
                    #endregion


                }


                if (rdnFiltre3.Checked == true)
                {
                 
                    var List1 = from meal in _db.Meals.Where(x => x.ContactUserID == user.UserID)
                                where meal.CreateTime.Day >= startDate.Day && meal.CreateTime.Day <= endDate.Day
                                join foodMeal in _db.FoodMeals on meal.MealID equals foodMeal.MealID
                                join food in _db.Foods on foodMeal.FoodID equals food.FoodID
                                join category in _db.Categories on food.CategoryId equals category.CategoryId
                                group foodMeal by new { meal.MealName,food.FoodName } into g
                                select new
                                {
                                    Meal = g.Key.MealName,
                                    Food = g.Key.FoodName,
                                    Grams = g.Sum(x => x.Grams)

                                };
                  


                    dgvStatisticsTable.DataSource = List1.ToList();

                    //dgvStatisticsTable.SelectedCells[0].OwningRow.DataBoundItem.ToString();

                }


            }
        }

        private void btnDailyReport_Click(object sender, EventArgs e)
        {
            using (_db=new())
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
                                      where meal.CreateTime.Day==DateTime.Now.Day
                                      join foodMeal in _db.FoodMeals on meal.MealID equals foodMeal.MealID
                                      join food in _db.Foods on foodMeal.FoodID equals food.FoodID
                                      join category in _db.Categories on food.CategoryId equals category.CategoryId
                                      group foodMeal by category.CategoryName into g
                                      select new
                                      {
                                          Category = g.Key,
                                          Calorie = g.Where(x => x.Meal.ContactUserID == user.UserID).Sum(x => x.Grams / 100 * (x.Food.FoodCal)),
                                          AvgCalories = g.Sum(x => x.Grams / 100 * (x.Food.FoodCal)) / _db.Users.Count()


                                      };

                dgvStatisticsTable.DataSource = DailyReportList.ToList();
            }
        

        }

        private void btnMonthlyReport_Click(object sender, EventArgs e)
        {
            using (_db = new())
            {

                var MonthlyReportList = from meal in _db.Meals
                                      where meal.CreateTime.Month == DateTime.Now.Month
                                      join foodMeal in _db.FoodMeals on meal.MealID equals foodMeal.MealID
                                      join food in _db.Foods on foodMeal.FoodID equals food.FoodID
                                      join category in _db.Categories on food.CategoryId equals category.CategoryId
                                      group foodMeal by category.CategoryName into g
                                      select new
                                      {
                                          Category = g.Key,
                                          Calorie = g.Where(x => x.Meal.ContactUserID == user.UserID).Sum(x => x.Grams / 100 * (x.Food.FoodCal)),
                                          AvgCalories = g.Sum(x => x.Grams / 100 * (x.Food.FoodCal)) / _db.Users.Count()


                                      };

                dgvStatisticsTable.DataSource = MonthlyReportList.ToList();

            }
        }

        private void btnWeeklyReport_Click(object sender, EventArgs e)
        {
            using (_db = new())
            {

                var WeeklyReportList = from meal in _db.Meals
                                        where meal.CreateTime >= DateTime.Now.AddDays(-7) && meal.CreateTime<= DateTime.Now
                                        join foodMeal in _db.FoodMeals on meal.MealID equals foodMeal.MealID
                                        join food in _db.Foods on foodMeal.FoodID equals food.FoodID
                                        join category in _db.Categories on food.CategoryId equals category.CategoryId
                                        group foodMeal by category.CategoryName into g
                                        select new
                                        {
                                            Category = g.Key,
                                            Calorie = g.Where(x => x.Meal.ContactUserID == user.UserID).Sum(x => x.Grams / 100 * (x.Food.FoodCal)),
                                            AvgCalories = g.Sum(x => x.Grams / 100 * (x.Food.FoodCal)) / _db.Users.Count()


                                        };

                dgvStatisticsTable.DataSource = WeeklyReportList.ToList();

            }
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            string data = "";
            StringBuilder str = new StringBuilder();
            str.Append(data);
            foreach (DataGridViewRow row in dgvStatisticsTable.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    // Her hücrenin değerini string değişkenimize ekleyin
                  str.Append(cell.Value.ToString() + " ");
                }

                // Satırlar arasına bir satır sonu karakteri ekleyin
                str.AppendLine();
            }

            // Elde edilen tüm verileri string değişkeninde tutun
            //MessageBox.Show(str.ToString());

            if (user.Email.Contains("@gmail.com"))
            {
                MailAddress MailReceiver = new MailAddress(user.Email, user.UserName);
                MailAddress MailSender = new MailAddress("calculatorcodesender@gmail.com", "Diet Application");
                MailMessage verificationMessage = new MailMessage();


                verificationMessage.To.Add(MailReceiver);
                verificationMessage.From = MailSender;
                verificationMessage.Subject = "Report";
                verificationMessage.Body = "Your Report : \n" + str.ToString();

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new System.Net.NetworkCredential("calculatorcodesender@gmail.com", "ijsqrsxodaulvybc");  //ijsqrsxodaulvybc
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                //smtp.Timeout   // Duruma göre bunu da ekle
                smtp.Send(verificationMessage);
            }



            #region Yedek
            //string data = "";
            //StringBuilder str = new StringBuilder();
            //str.Append(data);
            //foreach (DataGridViewRow row in dgvStatisticsTable.Rows)
            //{
            //    foreach (DataGridViewCell cell in row.Cells)
            //    {
            //        // Her hücrenin değerini string değişkenimize ekleyin
            //        data += cell.Value.ToString() + " ";
            //    }

            //    // Satırlar arasına bir satır sonu karakteri ekleyin
            //    data += Environment.NewLine;
            //}

            //// Elde edilen tüm verileri string değişkeninde tutun
            //MessageBox.Show(data);
            #endregion


        }

    }
}
