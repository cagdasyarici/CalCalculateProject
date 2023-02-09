using CalCalculatorDAL;
using CalCalculatorEntities;
using Microsoft.EntityFrameworkCore;
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
    public partial class AddFoodToMeal : Form
    {
        List<Food> foods = new();
        CalCalculateDB _db;

        Meal meal;
        public AddFoodToMeal(Meal currentMeal)
        {
            InitializeComponent();
            meal = currentMeal;
        }

        private void AddFoodToMeal_Load(object sender, EventArgs e)
        {

            using (_db = new CalCalculateDB())
            {
                dgv_FoodList.DataSource = _db.Foods.ToList();
                //Meal meal = (Meal)dtgw.SelectedCells[0].OwningRow.DataBoundItem;
            }

        }

        private void btnAddMealDetail_Click(object sender, EventArgs e)
        {
            #region Eski Kısım 
            Food selectedFood = dgv_FoodList.SelectedCells[0].OwningRow.DataBoundItem as Food;

            if (!foods.Contains(selectedFood))
            {


                //selectedFood.Grams = Convert.ToInt32(txtGrams.Text);


                foods.Add(selectedFood);
                dgv_MealDetails.DataSource = null;
                dgv_MealDetails.DataSource = foods;
                txtGrams.Text = string.Empty;
            }
            #endregion



        }

       

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Food selectedFood = dgv_MealDetails.SelectedCells[0].OwningRow.DataBoundItem as Food;
            foods.Remove(selectedFood);
            dgv_MealDetails.DataSource = null;
            dgv_MealDetails.DataSource = foods;
        }

        private void btnAddMeal_Click(object sender, EventArgs e)
        {
            #region Bi şey öğrendim
            //dynamic sonuc = dgv_MealDetails.DataSource;
            //ICollection<Food> foods = sonuc;
            //int selectedMealsID = meal.MealID;
            ///ICollection<Food> Şeklinde yakalayabiliyorum @@@@@@@@@@@@@@@@@@@@@@@
            #endregion




            var result = dgv_MealDetails.DataSource as List<Food>;


            using (_db = new())
            {
                foreach (var item in result)
                {
                    meal.FoodMeals = new List<FoodMeal>()
                    {
                        new FoodMeal()
                        {
                            FoodID = item.FoodID

                        }
                    };
                    _db.Update(meal);
                    _db.SaveChanges();
                }


            }





            #region Deneme2
            //Food? selectedFood = dgv_MealDetails.SelectedCells[0].OwningRow.DataBoundItem as Food;
            //int selectedID = selectedFood.FoodID;

            //using (_db = new())
            //{
            //    meal.FoodMeals = new HashSet<FoodMeal>()
            //    {
            //        new FoodMeal()
            //        {
            //            //Grams=int.Parse(txtGrams.Text),
            //            FoodID=selectedID
            //        }
            //    };

            //    //_db.Add();
            //    _db.SaveChanges();
            //}
            #endregion

            #region Çalışan Kopya2
            //using (_db = new())
            //{
            //    Food food = new Food()
            //    {
            //        FoodCal = 150,
            //        FoodCarb = 10,
            //        FoodFat = 10,
            //        FoodProt = 10,
            //        FoodName = "Mısır",
            //        CategoryId = 1,
            //        FoodMeals = new HashSet<FoodMeal>()
            //    {
            //        new()
            //        {   Grams=100,
            //            MealID=meal.MealID
            //        }
            //    }
            //    };

            //    _db.Add(food);
            //    _db.SaveChanges();
            //}
            #endregion

            #region Çalışan Kopya
            //using (_db = new())
            //{
            //    Food food = new Food()
            //    {
            //        FoodCal = 1000,
            //        FoodCarb = 10,
            //        FoodFat = 10,
            //        FoodProt = 10,
            //        FoodName = "çorba",
            //        CategoryId = 1,
            //        FoodMeals = new HashSet<FoodMeal>()
            //    {
            //        new()
            //        {
            //            MealID=3
            //        }
            //    }
            //    };

            //    _db.Add(food);
            //    _db.SaveChanges();
            //} 
            #endregion
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }
    }
}
