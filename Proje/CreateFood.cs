using CalCalculatorBLL;
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
    public partial class CreateFood : Form
    {
        public CreateFood()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string foodName = txtFoodName.Text;
            int foodCarb = Convert.ToInt32(txtCarbonh.Text);
            int foodFat = Convert.ToInt32(txtFat.Text);
            int foodProt = Convert.ToInt32(txtProt.Text);
            int foodCal = Convert.ToInt32(txtCal.Text);
            FoodServices foodServices = new FoodServices();
            foodServices.CreateFood(foodName, foodCarb, foodFat, foodProt, foodCal);
        }
    }
}
