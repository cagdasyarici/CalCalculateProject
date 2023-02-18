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

            if (UserDetailNullOrWhiteSpace) // todo:Aşağıda da benzer bi işlem yapılmış buna bi bak (yuşa)
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
                    bool userCreated;
                    userCreated = userServices.CreateUser(userName, password, email, securityQuestion, securityAnswer);
                    if (userCreated)
                    {
                        MessageBox.Show("User created successfully!");
                    }
                    else
                    {
                        MessageBox.Show("User name or E-mail is already used");
                    }

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
                MessageBox.Show("Please Fill Information Boxes", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
             private Point lastPoint; // Son konum bilgisini tutmak için bir değişken tanımlıyoruz.
        private void AdminPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y); // Son konum bilgisini alıyoruz.
        }

        private void AdminPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // Sol fare düğmesine basılırsa formun konumu değiştiriliyor.
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void AdminPanel_MouseUp(object sender, MouseEventArgs e)
        {
            lastPoint = Point.Empty; // Son konum bilgisini temizliyoruz.
        }

        private void btnShutDown_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Üyelik oluşturmadan çıkmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK) // OK butonuna basıldı
            {
                // Uygulamayı kapat
                this.Close();
            }
        }
        private void txtFocus(object sender, EventArgs e)
        {
            TxtFocus((TextBox)sender);
        }
        private void TxtFocus(TextBox textBox)
        {
            if (textBox.BackColor == Color.FromArgb(112, 117, 132))
            {
                textBox.BackColor = Color.FromArgb(148, 153, 168);
                textBox.ForeColor = Color.Black;
            }
            else
            {
                textBox.BackColor = Color.FromArgb(112, 117, 132);
                textBox.ForeColor = Color.Black;
            }
        }
    }
}
