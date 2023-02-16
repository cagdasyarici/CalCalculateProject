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
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            UserServices userServices = new UserServices();
            bool UserDetailNullOrWhiteSpace = userServices.CheckUserDetailsNullOrWhiteSpace(txtUsername.Text, txtMail.Text, txtPassword.Text, txtPassControl.Text, txtSecurity.Text);

            if (UserDetailNullOrWhiteSpace)
            {
                string userName = txtUsername.Text;
                string password = txtPassword.Text;
                string confirmPassword = txtPassControl.Text;
                string email = txtMail.Text;
                string securityQuestion = comboBox1.Text;
                string securityAnswer = txtSecurity.Text;
                bool result = password.Any(c => char.IsLetter(c)) && password.Any(c => char.IsDigit(c));
                if (userName != null && password != null && email != null && result && securityQuestion != null && securityAnswer != null && confirmPassword == password && password.Length > 6)
                {

                    userServices.CreateUser(userName, password, email, securityQuestion, securityAnswer);
                    MessageBox.Show("User created successfully!");
                    this.Hide();
                }
                else if (!result)
                {
                    lblWarning.Text = "Password must contains at least 1 alphabet character and 1 number.";
                }
                else if (confirmPassword != password)
                {
                    lblWarning.Text = "Password must be match";
                }
                else if (password.Length <= 6)
                {
                    lblWarning.Text = "Password must be contains at least 7 character";
                }
                else
                {
                    MessageBox.Show("User information can not be empty!");
                }
            }
            else
            {
                MessageBox.Show("Please Fill Information Boxes","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
           
        }

    }
}
