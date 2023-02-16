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
            if (txtMealName.Text.Trim() != null && txtMealName.Text.Trim() != "")
            {
                MealServices mealServices = new MealServices();
                mealServices.CreateMeal(txtMealName.Text, user.UserID);
            }
            else
            {
                MessageBox.Show("Meal name cannot be empty");
            }
            DGVFill();

        }
        bool totalCalorieBrought;
        private void btnShowMeals_Click(object sender, EventArgs e)
        {
            DGVFill();


        }
        private void DGVFill()
        {
            MealServices mealServices = new MealServices();
            dataGridView1.DataSource = mealServices.SearchByDate(dateTimePicker1.Value, dateTimePicker2.Value, user);
            dataGridView1.Columns["User"].Visible = false;
            dataGridView1.Columns["FoodMeals"].Visible = false;
            dataGridView1.Columns["ContactUserID"].Visible = false;
            if (!totalCalorieBrought)
            {
                //totalCalorieBrought = true;
                //dataGridView1.Columns.Add("TotalCalorie", "Total Calorie");
                //List<int> mealIDs =  mealServices.QueryableList().Select(x=>x.MealID).ToList();

                //foreach (DataGridViewRow row in dataGridView1.Rows)
                //{
                //    if (mealIDs.Contains((int)row.Cells[1].Value))
                //    {
                //        dataGridView1.Columns["TotalCalorie"]
                //        break;
                //    }
                //}
            }
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
            CreateFood createFood = new CreateFood(user);
            createFood.Show();
            this.Hide();
        }

        private void btnDeleteMeal_Click(object sender, EventArgs e)
        {
            try
            {
                Meal? meal;
                /* meal = (Meal)dataGridView1.CurrentRow.DataBoundItem; */ // Burda hata veriyor.Burda nasýl hata verebilir ki ?

                if (dataGridView1.CurrentRow.DataBoundItem is not null)
                {
                    meal = (Meal)dataGridView1.CurrentRow.DataBoundItem;
                MealServices mealServices = new MealServices();
                    mealServices.RemoveEntity(meal);
                    DGVFill();
                }
                else
                {
                    MessageBox.Show("error"); // sonra düzelt
                }
               
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please,select a Meal to delete first","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            catch (Exception)
            {

                MessageBox.Show("Error"); // todo: Buraya bir yazý düþün 
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            totalCalorieBrought = false;
            DGVFill();
        }
    }
}
