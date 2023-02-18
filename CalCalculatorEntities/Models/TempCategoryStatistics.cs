using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculatorEntities.Models
{
    public class TempCategoryStatistics  // todo: Daha sonra duruma göre sil
    {
        public string Category { get; set; }
        public double TotalColaries { get; set; }
        public double AverageCalories { get; set; }

        public DateTime Date { get; set; }
    }
}
