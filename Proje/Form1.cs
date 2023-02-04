using CalCalculatorBLL;
using CalCalculatorDAL;

using CalCalculatorEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class Form1 : Form
    {
        User user;
        public Form1(User userInfo)
        {
            user = userInfo;
            InitializeComponent();
        }
        private void btnAddMeal_Click(object sender, EventArgs e)
        {
            Meal meal = new Meal
            {
                MealName = txtMealName.Text,
                ContactUserID = user.UserID,
                CreateTime = DateTime.Now,
            };
            MealServices mealServices = new MealServices();
            mealServices.AddEntity(meal);
        }
        private void btnShowMeals_Click(object sender, EventArgs e)
        {
            MealServices mealServices = new MealServices();
            dataGridView1.DataSource = mealServices.SearchByDate(dateTimePicker1.Value,user);
        }
        private void DGVFill()
        {
            //dataGridView1.DataSource = _db.Meal.ToList();
        }
    }
}
