using CalCalculatorDAL;
using CalCalculatorEntities;

namespace Proje
{
    
    public partial class LoginForm : Form
    {
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
            //SignUpForm frm = new SignUpForm();
            //frm.ShowDialog();

            CalCalculatorEntities.User user = new CalCalculatorEntities.User()
            {
                UserName = "Cado",
                Password = "123",
                Email = "cado@gmail.com"
            };

            _db.User.Add(user);
            _db.SaveChanges();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = new User();
            user = _db.User.Find(txtUsername.Text);
            if (user != null)
            {
                MainForm frm = new MainForm();
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