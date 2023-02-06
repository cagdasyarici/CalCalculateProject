using CalCalculatorDAL;
using CalCalculatorDAL.Repositories;
using CalCalculatorEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculatorBLL
{
    public class UserServices:BaseRepository<User>
    {
        CalCalculateDB _db;
        int userID;
        string userName;
        string email;
        public UserServices()
        {

        }
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
        public UserServices(User user)
        {
            userID = user.UserID;
            userName = user.UserName;
            email = user.Email;
            
        }
        public int BringUserID()
        {
            return userID;
        }
        public string BringUserName()
        {
            return userName;
        }  
        public string BringUserEmail()
        {
            return email;
        }

        
    }
    
}
