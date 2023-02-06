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
        Meal meal;
        public AddFoodToMeal(Meal currentMeal)
        {
            InitializeComponent();
            meal = currentMeal;
        }

        private void AddFoodToMeal_Load(object sender, EventArgs e)
        {
            //var sonuc = meal.FoodMeals.
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnOgunEkle_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }
    }
}
