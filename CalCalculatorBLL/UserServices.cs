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
        public User FindUser(string userName)
        {
            using (_db= new CalCalculateDB())
            {
                User user = _db.Users.FirstOrDefault(x => x.UserName == userName);
                return user;
            }
        }
        //private void CheckPassword(string _password, string _confirmPassword)
        //{

        //    bool result = _password.Any(c => char.IsLetter(c)) && _password.Any(c => char.IsDigit(c));

        //    if ((_password == _confirmPassword) && !string.IsNullOrEmpty(_password))
        //    {
        //        if (result)
        //        {

        //            _db.Users.Where(x => x.UserName.Equals(txtUsername.Text)).FirstOrDefault().Password = _password; ///todo:Burayı sonra değiştir

        //            _db.SaveChanges();

        //            MessageBox.Show($"Your Password has been changed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }

        //        else
        //        {
        //            MessageBox.Show("Weak Password!", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }

        //    }

        //    else
        //    {
        //        MessageBox.Show("Please enter proper values", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }

        //}
    }
    
}
