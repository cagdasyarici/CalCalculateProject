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
        CalCalculateDB _db = new();
        public Form1(User userInfo)
        {
            InitializeComponent();
            user = userInfo;
        }
        User user = new User();
        private void btnAddMeal_Click(object sender, EventArgs e)
        {
            //MealOLUSSTUR();
            Meal meal = new Meal()
            {
                MealName = txtMealName.Text,
                ContactUserID = user.UserID,
                CreateTime = dateTimePicker1.Value
            };
            _db.Meals.Add(meal);
            _db.SaveChanges();
            DGWRefresh();
        }
        private void DGWRefresh()
        {
            var List =  _db.Meals.ToList();
            dataGridView1.DataSource = List;
        }

        private void btnShowMeals_Click(object sender, EventArgs e)
        {
            //Tarih 
            DGWRefresh();
        }
    }
}
