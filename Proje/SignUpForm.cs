using CalCalculatorBLL;
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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username=txtUsername.Text;
            string password=txtPassword.Text;
            //string 
            //UserServices userServices = new UserServices();
            //userServices.CreateUser(txt)
        }
    }
}
