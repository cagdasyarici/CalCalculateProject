using CalCalculatorDAL.Repositories;
using CalCalculatorEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculatorBLL
{
    public class MealServices:BaseRepository<Meal>
    {

        public List<Meal> SearchByDate(DateTime date, User user)
        {
            return QueryableList().Where(x => x.CreateTime.Date == date.Date&&x.ContactUserID==user.UserID).ToList();
        }
    }
}
