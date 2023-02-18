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
        bool categorySelected;
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
            dgvFood.Columns["FoodMeals"].Visible = false;
            dgvFood.Columns["Category"].Visible = false;


        }

        private void btnAddCategoryy_Click(object sender, EventArgs e)
        {

            CategoryServices categoryServices = new CategoryServices();
            FoodServices foodServices = new FoodServices();


            if (txtFoodName.Text.Trim() == "" || txtCarbonh.Text.Trim() == "" || txtFat.Text.Trim() == "" || txtProt.Text.Trim() == "" || txtCal.Text.Trim() == ""||categorySelected!=true)
            {
                MessageBox.Show("Food informations cannot be null");
            }
            else
            {
                try
                {
                    string foodName = txtFoodName.Text;
                    int foodCarb = Convert.ToInt32(txtCarbonh.Text);
                    int foodFat = Convert.ToInt32(txtFat.Text);
                    int foodProt = Convert.ToInt32(txtProt.Text);
                    int foodCal = Convert.ToInt32(txtCal.Text);
                    int categoryID = 0;
                    IList<Category> categoryList = categoryServices.SearchCategoryByName(cmbCategory.SelectedItem.ToString());
                    foreach (Category category in categoryList)
                    {
                        categoryID = category.CategoryId;
                    }
                    
                    bool foodCreated = foodServices.CreateFood(foodName, foodCarb, foodFat, foodProt, foodCal, categoryID);
                    if (foodCreated)
                    {
                        MessageBox.Show("Food created");
                    }
                    else
                    {
                        MessageBox.Show("Food already exists in database");
                    }
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Food informations are incorrect");
                }
                
            }
            foreach (Control c in grpFoodInformations.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = string.Empty;
                }
            }
            dgvFood.DataSource = foodServices.BringTList();
            dgvFood.Columns["FoodMeals"].Visible = false;
            dgvFood.Columns["Category"].Visible = false;
        }

        private void btnRemoveCategoryy_Click(object sender, EventArgs e)
        {

            FoodServices foodServices = new FoodServices();
            Food selectedFood = (Food)dgvFood.CurrentRow.DataBoundItem;
            foodServices.RemoveEntity(selectedFood);
            dgvFood.DataSource = foodServices.BringTList(); 
            dgvFood.Columns["FoodMeals"].Visible = false;
            dgvFood.Columns["Category"].Visible = false;
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            categorySelected=true;
        }
        private void txtFocus(object sender, EventArgs e)
        {
            TxtFocus((TextBox)sender);
        }
        private void TxtFocus(TextBox textBox)
        {
            if (textBox.BackColor == Color.FromArgb(112, 117, 132))
            {
                textBox.BackColor = Color.FromArgb(148, 153, 168);
                textBox.ForeColor = Color.Black;
            }
            else
            {
                textBox.BackColor = Color.FromArgb(112, 117, 132);
                textBox.ForeColor = Color.Black;
            }
        }

    }
}
