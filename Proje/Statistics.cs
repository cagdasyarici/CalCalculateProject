using CalCalculatorDAL;
using CalCalculatorEntities;
using CalCalculatorEntities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class Statistics : Form
    {
        CalCalculateDB _db;
        User user;
        

        public Statistics(User currentUser)
        {
            user= currentUser;
            InitializeComponent();
        }

        private void btn_Getir_Click(object sender, EventArgs e)
        {
            using (_db = new())
            {
                if (rdnToplamCal.Checked==true)
                {
                    /// user'ın meal listesine ulaş 
                    /// tarihe göre ayıkla(Created Time)
                    /// 
                    double TopCal = 0;
                   //var sonuc = user.Meals.Where(x => x.CreateTime <= dtpEndDate.Value && x.CreateTime>=dtpStartDate.Value).ToList();
                   List<Meal> selectedMeals = _db.Meals.Where(x => x.CreateTime <= dtpEndDate.Value && x.CreateTime>=dtpStartDate.Value&& x.ContactUserID==user.UserID).ToList();
                   
                    foreach (Meal item in selectedMeals)
                    {
                        TopCal = item.TotalCalorie + TopCal;
                    }

                    txtTopcal.Text = TopCal.ToString();
                }


                if (rdnCategories.Checked==true)
                {
                    TempCategoryStatistics tmp = new();


                }
            }
        }
    }
}
