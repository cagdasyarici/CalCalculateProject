﻿using CalCalculatorDAL;
using CalCalculatorEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculatorBLL
{
    public class MailServices
    {
        CalCalculateDB _db;



        /// <summary>
        /// Hotmail.com mail adresleri için doğrulama Kodu gönderir
        /// </summary>
        public void HotmailSendVerificationCode(string mailAdress, string username, string code)
        {

            MailAddress MailReceiver = new MailAddress(mailAdress, username);
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
        /// <summary>
        /// gmail.com mail adresleri için doğrulama Kodu gönderir
        /// </summary>
        public void GmailSendVerificationCode(string mailAdress, string username, string code)
        {

            MailAddress MailReceiver = new MailAddress(mailAdress, username);
            MailAddress MailSender = new MailAddress("calculatorcodesender@gmail.com", "CodeSender");
            MailMessage verificationMessage = new MailMessage();


            verificationMessage.To.Add(MailReceiver);
            verificationMessage.From = MailSender;
            verificationMessage.Subject = "Change Password";
            verificationMessage.Body = "Verification Code to Change Password : " + code;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new System.Net.NetworkCredential("calculatorcodesender@gmail.com", "ijsqrsxodaulvybc");  //ijsqrsxodaulvybc
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            //smtp.Timeout   // Duruma göre bunu da ekle
            smtp.Send(verificationMessage);

        }
        /// <summary>
        /// 6 Haneli Kod Üretir
        /// </summary>
        /// <returns></returns>
        public string Generate6DigitCode()
        {
            #region Eski kod
            //Random rnd = new Random();
            //return rnd.Next(100000, 999999).ToString(); 
            #endregion

            byte[] bytes = new byte[6];
            RandomNumberGenerator rng = RandomNumberGenerator.Create();
            rng.GetBytes(bytes);
            string code = Convert.ToBase64String(bytes).Substring(0, 6);

            return code;
        }
        /// <summary>
        /// Girilen username'e ait şifreyi değiştirir
        /// </summary>
        /// <param name="_username"></param>
        /// <param name="_password"></param>
        public void ChangePassword(string _username, string _password, string _confirmPassword)
        {
            using (_db = new CalCalculateDB())
            {
                _db.Users.Where(x => x.UserName.Equals(_username)).FirstOrDefault().Password = _password; ///todo:Burayı sonra değiştir (Yuşa)

                _db.SaveChanges();
            }
        }

        public void ContactUsMail(User user, string ContactUsText)
        {
            MailAddress MailReceiver = new MailAddress("CalCalculateContactUS@gmail.com", "CalCalculate Team"); //Mail Adresi : CalCalculateContactUS@gmail.com   Şifre: Cal.5224  Üyeler App'in geliştirici takımına bu mail adresinden ulaşacaklar

            MailAddress MailSender = new MailAddress("calculatorcodesender@gmail.com", "CodeSender");
            MailMessage ContactUsMessage = new MailMessage();

            ContactUsMessage.To.Add(MailReceiver);
            ContactUsMessage.From = MailSender;
            ContactUsMessage.Subject = $"From {user.UserName}";
            ContactUsMessage.Body = $"Dear CalCalculate Team : " + ContactUsText;


            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new System.Net.NetworkCredential("calculatorcodesender@gmail.com", "ijsqrsxodaulvybc");  //ijsqrsxodaulvybc
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            //smtp.Timeout   // Duruma göre bunu da ekle
            smtp.Send(ContactUsMessage);
        }

        public void StatisticsReportMail(User user, StringBuilder str)
        {


            // Elde edilen tüm verileri string değişkeninde tutun
            //MessageBox.Show(str.ToString());

            if (user.Email.Contains("@gmail.com"))
            {
                MailAddress MailReceiver = new MailAddress(user.Email, user.UserName);
                MailAddress MailSender = new MailAddress("calculatorcodesender@gmail.com", "Diet Application");
                MailMessage verificationMessage = new MailMessage();


                verificationMessage.To.Add(MailReceiver);
                verificationMessage.From = MailSender;
                verificationMessage.Subject = "Report";
                verificationMessage.Body = "Your Report : \n" + str.ToString();

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new System.Net.NetworkCredential("calculatorcodesender@gmail.com", "ijsqrsxodaulvybc");  //ijsqrsxodaulvybc
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                //smtp.Timeout   // Duruma göre bunu da ekle
                smtp.Send(verificationMessage);
            }
        }

        public dynamic GetSecurityList(string username)
        {
            return _db.Users.Where(x => x.UserName.Equals(username)).Select(x => new { x.SecurityQuestion, x.SecurityAnswer }).ToList();
        }

        public dynamic GetEmailAdress(string emailAdress)
        {
           return _db.Users.Where(x => x.UserName.Equals(emailAdress)).FirstOrDefault().Email;
        }


    }
}
