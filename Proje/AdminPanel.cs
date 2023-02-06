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
    public partial class AdminPanel : Form
    {
        User user;
        public AdminPanel(User userInfo)
        {
            user=userInfo;
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            UserServices userServices = new UserServices();
            lblUserName.Text = userServices.BringUserName();
            lblEmail.Text = userServices.BringUserEmail();
        }

        private void btnCreateFood_Click(object sender, EventArgs e)
        {
            CreateFood createFood = new CreateFood(user);
            createFood.Show();
            this.Hide();
        }

        private void btnCreateCategory_Click(object sender, EventArgs e)
        {
            CreateCategory createCategory = new CreateCategory(user);
            createCategory.Show();
            this.Hide();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            
            Form1 frm = new Form1(user);
            frm.Show();
            this.Hide();
        }
    }
}
