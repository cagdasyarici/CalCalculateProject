using CalCalculatorDAL;
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
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            using (_db=new())
            {
                var SecurityList = _db.Users.Where(x => x.UserName.Equals(txtUsername.Text)).Select(x => new { x.SecurityQuestion, x.SecurityAnswer }).ToList();

                foreach (var item in SecurityList)
                {
                    if (item.SecurityAnswer.Equals(txtSecurityAnswer.Text) && item.SecurityQuestion.Equals(txtSecurityQuestion.Text))
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
        }

        private void btnVerificationCode_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            code = rnd.Next(100000, 999999).ToString();

            
            MailAddress MailReceiver = new MailAddress(txtEMailAdress.Text,txtUsername.Text);
            MailAddress MailSender = new MailAddress("CalculatorCodeSender@hotmail.com","CodeSender");
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

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (txtVerificationCode.Text.Equals(code))
            {
                grpChangePassword.Enabled = true;
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {

            using (_db = new CalCalculateDB())
            {
                if (txtPassword.Text == txtPasswordConfirm.Text)
                {
                    _db.Users.Where(x => x.UserName.Equals(txtUsername.Text)).FirstOrDefault().Password = txtPassword.Text; ///Burayı sonradan değiştiricem
                    _db.SaveChanges();

                    MessageBox.Show($"Your Password has been changed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }
    }
}
