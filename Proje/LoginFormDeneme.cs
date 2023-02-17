using CalCalculatorBLL;
using CalCalculatorDAL;
using CalCalculatorEntities;
using System.Security.Cryptography.X509Certificates;
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
    public partial class LoginFormDeneme : Form
    {
        public LoginFormDeneme()
        {
            InitializeComponent();
            CategoryServices categoryServices = new CategoryServices();
            categoryServices.CreateDefaultCategoriesIfNotExist();
        }
        private void lblForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPasswordForm frm = new ForgotPasswordForm();
            frm.ShowDialog();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm frm = new SignUpForm();
            frm.ShowDialog();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            UserServices userServices = new UserServices();
            User? user = new User();
            user = userServices.FindUser(userName);

            if (user is not null)
            {
                if (user.Password == txtPassword.Text)

                {
                    if (!user.IsAdmin)
                    {
                        //Form1 frm = new Form1(user);
                        MainFormDeneme mainForm = new MainFormDeneme(user);

                        mainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        AdminPanelDeneme panel = new AdminPanelDeneme(user);
                        panel.Show();
                        this.Hide();
                    }


                }
                else
                {
                    MessageBox.Show("Invalid username or password", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnShutDown_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Uygulamadan çıkmak istediğinize emin misiniz?", "Uygulamadan Çıkış", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK) // OK butonuna basıldı
            {
                // Uygulamayı kapat
                Application.Exit();
            }
        }

    }
}
