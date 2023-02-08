using CalCalculatorBLL;
using CalCalculatorDAL;
using CalCalculatorEntities;
using System.Security.Cryptography.X509Certificates;

namespace Proje
{
    
    public partial class LoginForm : Form
    {
        
        
        public LoginForm()
        {
            InitializeComponent();
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

            //CalCalculatorEntities.User user = new CalCalculatorEntities.User()
            //{
            //    UserName = "yusa",
            //    Password = "123",
            //    Email = "yusa@gmail.com"
            //};

            //_db.Users.Add(user);
            //_db.SaveChanges();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            UserServices userServices = new UserServices();
            User user = userServices.FindUser(userName);
            if (user.Password==txtPassword.Text)

            {
                if (!user.IsAdmin)
                {
                    Form1 frm = new Form1(user);
                    
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    AdminPanel panel = new AdminPanel(user);
                    panel.Show();
                    this.Hide();
                }
               
                
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }

        }
    }
}