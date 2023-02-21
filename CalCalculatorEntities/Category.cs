using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculatorEntities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        //Navigation
        public virtual ICollection<Food> Foods { get; set; }
        public Category()
        {
            Foods = new HashSet<Food>();
        }
    }
}
