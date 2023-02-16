using CalCalculatorBLL;
using CalCalculatorEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class CreateFood : Form
    {
        User user;
        public CreateFood()
        {
            InitializeComponent();
            CategoryServices categoryServices = new CategoryServices();
            categoryServices.CreateDefaultCategoriesIfNotExist();
            List<string> categoryNames = categoryServices.BringCategoryNames();
            foreach(string categoryName in categoryNames)
            {
                cmbCategory.Items.Add(categoryName);
            }
        }

        

        private void CreateFood_Load(object sender, EventArgs e)
        {
            FoodServices foodServices=new FoodServices();
            dgvFood.DataSource = foodServices.BringTList();
        }

        private void btnAddCategoryy_Click(object sender, EventArgs e)
        {

            CategoryServices categoryServices = new CategoryServices();

            IList<Category> categoryList = categoryServices.SearchCategoryByName(cmbCategory.SelectedItem.ToString());
            string foodName = txtFoodName.Text;
            int foodCarb = Convert.ToInt32(txtCarbonh.Text);
            int foodFat = Convert.ToInt32(txtFat.Text);
            int foodProt = Convert.ToInt32(txtProt.Text);
            int foodCal = Convert.ToInt32(txtCal.Text);
            int categoryID = 0;
            foreach (Category category in categoryList)
            {
                categoryID = category.CategoryId;
            }
            FoodServices foodServices = new FoodServices();
            bool foodCreated = foodServices.CreateFood(foodName, foodCarb, foodFat, foodProt, foodCal, categoryID);
            if (foodCreated)
            {
                MessageBox.Show("Food created");
            }
            else
            {
                MessageBox.Show("Food already exists in database");
            }
            dgvFood.DataSource = foodServices.BringTList();
        }

        private void btnRemoveCategoryy_Click(object sender, EventArgs e)
        {

            FoodServices foodServices = new FoodServices();
            Food selectedFood = (Food)dgvFood.CurrentRow.DataBoundItem;
            foodServices.RemoveEntity(selectedFood);
            dgvFood.DataSource = foodServices.BringTList();
        }
    }
}
