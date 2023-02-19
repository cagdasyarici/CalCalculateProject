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
    public partial class CreateCategory : Form
    {
        public CreateCategory()
        {
            InitializeComponent();
        }

        private void CreateCategory_Load(object sender, EventArgs e)
        {
            DGVFill();
        }

        private void DGVFill()
        {
            CategoryServices categoryServices = new CategoryServices();
            dgvCategories.DataSource = categoryServices.BringTList();
            dgvCategories.Columns["Foods"].Visible= false;
        }

       

        private void btnRemoveCategoryy_Click(object sender, EventArgs e)
        {
            Category selectedCategory = (Category)dgvCategories.CurrentRow.DataBoundItem;
            CategoryServices categoryServices = new CategoryServices();
            categoryServices.RemoveEntity(selectedCategory);
            DGVFill();
        }

        private void btnAddCategoryy_Click(object sender, EventArgs e)
        {
            string categoryName = txtCategoryName.Text;
            CategoryServices categoryServices = new CategoryServices();
            if(categoryName !="") 
            {
                if (categoryServices.BringCategoryNames().Contains(categoryName))
                {
                    MessageBox.Show("Category already exist in database");
                }
                bool categoryCreated = categoryServices.CreateCategoryIfNotExist(categoryName);
                if (categoryCreated)
                {
                    MessageBox.Show("Category successfully created.");
                }
                DGVFill();
            }
            else
            {
                MessageBox.Show("Category name cannot be null");
            }
            
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
