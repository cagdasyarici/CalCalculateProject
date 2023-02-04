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
        public void CreateUser(string name,string password,string email)
        {
            CalCalculateDB _db = new CalCalculateDB();
            User user = new User
            {
                UserName = name,
                Password = password,
                Email = email
            };
            AddEntity(user);
        }
    }
    
}
