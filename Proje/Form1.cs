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
            MealServices mealServices = new MealServices();
            mealServices.CreateMeal(txtMealName.Text, user.UserID);
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dtgw = (DataGridView)sender;
            Meal meal = (Meal)dtgw.SelectedCells[0].OwningRow.DataBoundItem;
            AddFoodToMeal addFoodToMeal = new AddFoodToMeal(meal);
            addFoodToMeal.Show();
            this.Close();
        }

        private void btnCreateFoodForm_Click(object sender, EventArgs e)
        {
            CreateFood createFood=new CreateFood();
            createFood.Show();
        }
    }
}
