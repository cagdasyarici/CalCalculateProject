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
    public partial class AddFoodToMeal : Form
    {
        List<Food> foods = new();
        CalCalculateDB _db;

        Meal meal;
        public AddFoodToMeal(Meal currentMeal)
        {
            InitializeComponent();
            meal = currentMeal;
        }

        private void AddFoodToMeal_Load(object sender, EventArgs e)
        {

            using (_db = new CalCalculateDB())
            {
                dgv_FoodList.DataSource = _db.Foods.ToList();
                //Meal meal = (Meal)dtgw.SelectedCells[0].OwningRow.DataBoundItem;
            }

        }

        private void btnAddMealDetail_Click(object sender, EventArgs e)
        {
            Food selectedFood = dgv_FoodList.SelectedCells[0].OwningRow.DataBoundItem as Food;

            if (!foods.Contains(selectedFood))
            {

                if (!string.IsNullOrWhiteSpace(txtGrams.Text))
                {
                    selectedFood.Grams = Convert.ToInt32(txtGrams.Text);
                }
               
                foods.Add(selectedFood);
                dgv_MealDetails.DataSource = null;
                dgv_MealDetails.DataSource = foods;
                txtGrams.Text = string.Empty;
            }

        }

        private void dgv_MealDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Food selectedFood = dgv_MealDetails.SelectedCells[0].OwningRow.DataBoundItem as Food;
            foods.Remove(selectedFood);
            dgv_MealDetails.DataSource = null;
            dgv_MealDetails.DataSource = foods;
        }

        private void btnAddMeal_Click(object sender, EventArgs e)
        {
            Food selectedFood = dgv_MealDetails.SelectedCells[0].OwningRow.DataBoundItem as Food;
        }
    }
}
