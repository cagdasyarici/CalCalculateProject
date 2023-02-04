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
        public Form1(User user)
        {
            InitializeComponent();
            userr = user;
        }
        public User userr = new User();
        private void btnAddMeal_Click(object sender, EventArgs e)
        {
            Meal meal = new Meal()
            {
                MealName = txtMealName.Text,
                ContactUserID = userr.UserID,
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
    }
}
