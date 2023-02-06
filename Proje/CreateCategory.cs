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
        User user;
        public CreateCategory(User userInfo)
        {
            user=userInfo;
            InitializeComponent();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string categoryName = txtCategoryName.Text;
            CategoryServices categoryServices = new CategoryServices();
            if (categoryServices.BringCategoryNames().Contains(categoryName))
            {
                MessageBox.Show("Category already exist in database");
            }
            categoryServices.CreateCategoryIfNotExist(categoryName);
            DGVFill();
        }

        private void CreateCategory_Load(object sender, EventArgs e)
        {
            
            DGVFill();
        }

        private void DGVFill()
        {
            CategoryServices categoryServices = new CategoryServices();
            dgvCategories.DataSource = categoryServices.BringTList();
        }

        private void btnRemoveCategory_Click(object sender, EventArgs e)
        {
            Category selectedCategory = (Category)dgvCategories.CurrentRow.DataBoundItem;
            CategoryServices categoryServices = new CategoryServices();
            categoryServices.RemoveEntity(selectedCategory);
            DGVFill();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            
            Form1 frm = new Form1(user);
            frm.Show();
            this.Hide();
        }
    }
}
