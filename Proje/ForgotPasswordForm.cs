using CalCalculatorBLL;
using CalCalculatorDAL;
using CalCalculatorEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class ForgotPasswordForm : Form
    {
        CalCalculateDB _db;
        string code;
        User user;
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }
        public ForgotPasswordForm(User userInfo)
        {
            userInfo = user;
        }

        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {
            grpMail.Enabled = false;
            grpChangePassword.Enabled = false;

            cmbSecurityQuestions.SelectedItem = cmbSecurityQuestions.Items[0].ToString();

        }


        private void CheckPassword(string _username,string _password, string _confirmPassword)
        {

            bool result = _password.Any(c => char.IsLetter(c)) && _password.Any(c => char.IsDigit(c));

            if ((_password == _confirmPassword) && !string.IsNullOrEmpty(_password))
            {
                if (result)
                {
                     MailServices mailServices = new MailServices();
                    mailServices.ChangePassword(_username,_password, _confirmPassword);

                    #region ESKİ
                    //_db.Users.Where(x => x.UserName.Equals(txtUsername.Text)).FirstOrDefault().Password = _password; ///todo:Burayı sonra değiştir (Yuşa)

                    //_db.SaveChanges(); 
                    #endregion

                    MessageBox.Show($"Your Password has been changed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Weak Password!", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            else
            {
                MessageBox.Show("Please enter proper values", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void btnNexxt_Click(object sender, EventArgs e)
        {
            using (_db = new())
            {
                var SecurityList = _db.Users.Where(x => x.UserName.Equals(txtUsername.Text)).Select(x => new { x.SecurityQuestion, x.SecurityAnswer }).ToList();
                bool isUserExist = false;
                foreach (var item in SecurityList)
                {


                    if (item.SecurityAnswer.Equals(txtSecurityAnswer.Text) && item.SecurityQuestion.Equals(cmbSecurityQuestions.SelectedItem as string))

                    {
                        grpMail.Enabled = true;
                        txtEMailAdress.Enabled = false;

                        txtEMailAdress.Text = _db.Users.Where(x => x.UserName.Equals(txtUsername.Text)).FirstOrDefault().Email;
                        grpSecurity.Enabled = false;
                        isUserExist = true;
                    }


                }

                if (!isUserExist)
                {
                    MessageBox.Show("Please check your informations", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        /// <summary>
        /// Girilen değer doğrulama koduyla aynıysa sonraki adımı açar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnApplyy_Click(object sender, EventArgs e)
        {

            if (txtVerificationCode.Text.Equals(code))
            {
                grpChangePassword.Enabled = true;
                grpMail.Enabled = false;
            }
            else if (txtVerificationCode.Text == String.Empty)
            {
                MessageBox.Show("Please Fill The Verification Code Textbox", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Incorrect Code!");
            }

        }
        /// <summary>
        /// Girilen 2 şifre birbiriyle uyuşuyorsa databasedeki şifreyi değiştirir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChangee_Click(object sender, EventArgs e)
        {
            using (_db = new CalCalculateDB())
            {
                CheckPassword(txtUsername.Text,txtPassword.Text, txtPasswordConfirm.Text);
            }
        }
        /// <summary>
        /// Kullanıcının databasede bulunan Mail adresine 6 haneli bir doğrulama kodu gönderir        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSendVerificationn_Click(object sender, EventArgs e)
        {
            MailServices mailServices = new MailServices();
            code =mailServices.Generate6DigitCode();
           

            if (txtEMailAdress.Text.Contains("@gmail.com"))
            {
                mailServices.GmailSendVerificationCode(txtEMailAdress.Text, txtUsername.Text, code);
            }
            else if (txtEMailAdress.Text.Contains("@hotmail.com"))
            {
                mailServices.HotmailSendVerificationCode(txtEMailAdress.Text, txtUsername.Text, code);
            }

            #region Eski Kısım

            //MailAddress MailReceiver = new MailAddress(txtEMailAdress.Text,txtUsername.Text);
            //MailAddress MailSender = new MailAddress("CalculatorCodeSender@hotmail.com","CodeSender");
            //MailMessage verificationMessage = new MailMessage();


            //verificationMessage.To.Add(MailReceiver);
            //verificationMessage.From = MailSender;
            //verificationMessage.Subject = "Change Password";
            //verificationMessage.Body = "Verification Code to Change Password : " + code;

            //SmtpClient smtp = new SmtpClient("smtp.outlook.com", 587);
            //smtp.Credentials = new System.Net.NetworkCredential("CalculatorCodeSender@hotmail.com", "Cal.5224");
            //smtp.EnableSsl = true;
            //smtp.Send(verificationMessage); 
            #endregion



        }

        private void btnShutDown_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Şifre değiştirmeden çıkmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK) // OK butonuna basıldı
            {
                // Uygulamayı kapat
                this.Close();
            }
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
    }
}
