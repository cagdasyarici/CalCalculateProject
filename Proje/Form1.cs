
﻿using CalCalculatorBLL;
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
        User user1;
        public Form1(User user)

        {
            user1= user;
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
        

        private void btnAddMeal_Click(object sender, EventArgs e)
        {

            Meal meal = new Meal
            {
                MealName = txtMealName.Text,
                ContactUserID = user1.UserID,
                CreateTime= DateTime.Now,
            };
            MealServices mealServices= new MealServices();
            mealServices.AddEntity(meal);
            
        }

        private void btnShowMeals_Click(object sender, EventArgs e)
        {
            MealServices mealServices = new MealServices();
            dataGridView1.DataSource = mealServices.SearchByDate(dateTimePicker1.Value);
        }

        private void DGVFill()
        {
            //dataGridView1.DataSource = _db.Meal.ToList();
        }
    }
}
