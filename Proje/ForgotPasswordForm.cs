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
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Girilen bilgiler databasedekilerle uyuşuyorsa sıradaki adımı açar  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            using (_db=new())
            {
                var SecurityList = _db.Users.Where(x => x.UserName.Equals(txtUsername.Text)).Select(x => new { x.SecurityQuestion, x.SecurityAnswer }).ToList();

                foreach (var item in SecurityList)
                {

                    if (item.SecurityAnswer.Equals(txtSecurityAnswer.Text) && item.SecurityQuestion.Equals(cmbSecurityQuestions.SelectedItem as string))

                    {
                        grpMail.Enabled = true;
                        txtEMailAdress.Enabled = false;

                        txtEMailAdress.Text = _db.Users.Where(x => x.UserName.Equals(txtUsername.Text)).FirstOrDefault().Email;
                    }
                }

            }
        }

        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {
            grpMail.Enabled = false;
            grpChangePassword.Enabled = false;

            cmbSecurityQuestions.SelectedItem = cmbSecurityQuestions.Items[0].ToString();

        }
        /// <summary>
        /// Kullanıcının databasede bulunan Mail adresine 6 haneli bir doğrulama kodu gönderir        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVerificationCode_Click(object sender, EventArgs e)
        {
            code = Generate6DigitCode();

            SendVerificationCode();

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

        /// <summary>
        /// Girilen değer doğrulama koduyla aynıysa sonraki adımı açar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnApply_Click(object sender, EventArgs e)
        {
            if (txtVerificationCode.Text.Equals(code))
            {
                grpChangePassword.Enabled = true;
            }
        }

        /// <summary>
        /// Girilen 2 şifre birbiriyle uyuşuyorsa databasedeki şifreyi değiştirir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChange_Click(object sender, EventArgs e)
        {

            using (_db = new CalCalculateDB())
            {
                #region Eski Kısım
                //if ((txtPassword.Text == txtPasswordConfirm.Text) && !string.IsNullOrEmpty(txtPassword.Text))
                //{
                //    _db.Users.Where(x => x.UserName.Equals(txtUsername.Text)).FirstOrDefault().Password = txtPassword.Text; ///todo:Burayı sonra değiştir
                //    _db.SaveChanges();

                //    MessageBox.Show($"Your Password has been changed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}

                //else
                //{
                //    MessageBox.Show("Please enter proper values", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                //} 

                //}

                #endregion

                #region Yeni Kısım



                CheckPassword(txtPassword.Text, txtPasswordConfirm.Text);


                #endregion
            }
            
        }


        private void CheckPassword(string _password,string _confirmPassword)
        {

            bool result = _password.Any(c => char.IsLetter(c)) && _password.Any(c => char.IsDigit(c));

            if ((_password == _confirmPassword) && !string.IsNullOrEmpty(_password))
            {
                if (result)
                {

                    _db.Users.Where(x => x.UserName.Equals(txtUsername.Text)).FirstOrDefault().Password = _password; ///todo:Burayı sonra değiştir

                    _db.SaveChanges();

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
        /// <summary>
        /// 6 Haneli Kod Üretir
        /// </summary>
        /// <returns></returns>
        public string Generate6DigitCode()
        {
            Random rnd = new Random();
            return rnd.Next(100000, 999999).ToString();
        }
        /// <summary>
        /// Hotmail.com mail adresleri için doğrulama Kodu gönderir
        /// </summary>
        public void SendVerificationCode()
        {

            MailAddress MailReceiver = new MailAddress(txtEMailAdress.Text, txtUsername.Text);
            MailAddress MailSender = new MailAddress("CalculatorCodeSender@hotmail.com", "CodeSender");
            MailMessage verificationMessage = new MailMessage();


            verificationMessage.To.Add(MailReceiver);
            verificationMessage.From = MailSender;
            verificationMessage.Subject = "Change Password";
            verificationMessage.Body = "Verification Code to Change Password : " + code;

            SmtpClient smtp = new SmtpClient("smtp.outlook.com", 587);
            smtp.Credentials = new System.Net.NetworkCredential("CalculatorCodeSender@hotmail.com", "Cal.5224");
            smtp.EnableSsl = true;
            smtp.Send(verificationMessage);
        }
    }
}
