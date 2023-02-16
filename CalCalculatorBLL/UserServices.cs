using CalCalculatorDAL;
using CalCalculatorDAL.Repositories;
using CalCalculatorEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculatorBLL
{
    public class UserServices:BaseRepository<User>
    {
        CalCalculateDB _db;

        public UserServices()
        {

        }
        /// <summary>
        /// Girilen parametrelere sahip kullanıcıyı yaratıp database'e kaydeder
        /// </summary>
        /// <param name="name"></param>
        /// <param name="password"></param>
        /// <param name="email"></param>
        /// <param name="securityQuestion"></param>
        /// <param name="securityAnswer"></param>
        public void CreateUser(string name,string password,string email, string securityQuestion, string securityAnswer)
        {
            using (_db = new CalCalculateDB())
            {
                User user = new User
                {
                    UserName = name,
                    Password = password,
                    Email = email,
                    SecurityQuestion = securityQuestion,
                    SecurityAnswer = securityAnswer
                };
                AddEntity(user);
            }
            
        }
        /// <summary>
        /// KullanıcıAdı girilen kullanıcıyı database'de bulur
        /// </summary>
        /// <param name="userName"></param>
        /// <returns>Bulduğu kullanıcıyı User tipinde geri döndürür</returns>
        public User FindUser(string userName)
        {
            using (_db= new CalCalculateDB())
            {
                User user = _db.Users.FirstOrDefault(x => x.UserName == userName);
                return user;
            }
        }

        /// <summary>
        /// Kullanıcının Null olup olmadığını kontrol eder
        /// </summary>
        /// <param name="user"></param>
        /// <returns>Kullanıcı Null'sa True,Değilse Flase döner</returns>
        public bool CheckUserIsNullOrEmpty(User user)
        {
          return  user == null ? true : false;
        }


        /// <summary>
        /// Sign-Up ekranında Kullanıcının bütün bilgilerini eksiksiz girip girmediğini kontrol eder
        /// </summary>
        /// <param name="username"></param>
        /// <param name="mail"></param>
        /// <param name="password"></param>
        /// <param name="passwordControl"></param>
        /// <param name="security"></param>
        /// <returns>TextBoxların tamamı doluysa True,Değilse Flase döner</returns>
        public bool CheckUserDetailsNullOrWhiteSpace(string username,string mail,string password,string passwordControl,string security)
        {
            if (!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(mail) && !string.IsNullOrWhiteSpace(password) && !string.IsNullOrWhiteSpace(passwordControl) && !string.IsNullOrWhiteSpace(security))
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
    
}
