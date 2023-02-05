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
    public class FoodServices:BaseRepository<Food>
    {
        CalCalculateDB _db;
        public void CreateFood()
        {
            using(_db = new CalCalculateDB()) 
            {
                Food food = new Food
                {

                };

            }
        }
    }
}
