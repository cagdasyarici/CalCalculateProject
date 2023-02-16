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
            CategoryServices categoryServices= new CategoryServices();
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
            
            if(user is not null)
            {
                if (user.Password == txtPassword.Text)

                {
                    if (!user.IsAdmin)
                    {
                        //Form1 frm = new Form1(user);

                        //frm.Show();
                        //this.Hide();
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
                    MessageBox.Show("Invalid username or password","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    MainFormDeneme sidebar = new(user);
        //    sidebar.ShowDialog();
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    LoginFormDeneme loginform = new();
        //    loginform.ShowDialog();
        //}
    }
}