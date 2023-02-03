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
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MainForm frm = new MainForm();
            frm.Show();
            this.Hide();
        }
    }
}