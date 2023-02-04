using CalCalculatorDAL;
using CalCalculatorEntities;
using System.Security.Cryptography.X509Certificates;

namespace Proje
{
    
    public partial class LoginForm : Form
    {
        public User user;

        CalCalculateDB _db = new();
        
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
            user = _db.Users.FirstOrDefault(x => x.UserName.Contains(txtUsername.Text));
            if (user.Password==txtPassword.Text)

            {
                Form1 frm = new Form1(user);
                frm.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("YANLIÞ KULLANICI ADI VEYA ÞÝFRE");
            }

        }
    }
}