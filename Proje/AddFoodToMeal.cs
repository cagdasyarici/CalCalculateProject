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
        List<int> tempList1 = new List<int>();
        List<Food> tempList2 = new List<Food>();

        List<Food> foodListDgv;
        List<Food> foods = new();
        CalCalculateDB _db;

        Meal meal;
        public AddFoodToMeal(Meal currentMeal)
        {
            InitializeComponent();
            meal = currentMeal;
            txtGrams.Text = "0";
        }

        private void AddFoodToMeal_Load(object sender, EventArgs e)
        {
            foodListDgv = new();
            using (_db = new CalCalculateDB())
            {

                #region Dgv2 Doldurma

                foodListDgv = _db.Foods.ToList();
                dgv_FoodList.DataSource = foodListDgv;

                #endregion


                #region Dgv1 Doldurma

                
                tempList1 = _db.FoodMeals.Where(x => x.MealID == meal.MealID).Select(x=>x.FoodID).ToList();

                foreach (var IdNumber in tempList1)
                {
                    foods.Add(_db.Foods.Where(x => x.FoodID == IdNumber).FirstOrDefault());
                }

                dgv_MealDetails.DataSource = foods;
                //tempList2.Add(_db.Foods.i)

                

                #endregion

            }

        }

        private void btnAddMealDetail_Click(object sender, EventArgs e)
        {
            #region Eski Kısım 
            //Food selectedFood = dgv_FoodList.SelectedCells[0].OwningRow.DataBoundItem as Food;

            //if (!foods.Contains(selectedFood))
            //{


            //    //selectedFood.Grams = Convert.ToInt32(txtGrams.Text);


            //    foods.Add(selectedFood);
            //    dgv_MealDetails.DataSource = null;
            //    dgv_MealDetails.DataSource = foods;
            //    txtGrams.Text = string.Empty;
            //}
            #endregion

            #region Yeni Kısım 


            using (_db = new CalCalculateDB())
            {
                Food? selectedFood = dgv_FoodList.SelectedCells[0].OwningRow.DataBoundItem as Food;


                meal.FoodMeals.Add(new FoodMeal()
                {
                    Food = selectedFood,
                    Grams = int.Parse(txtGrams.Text)
                });

                _db.Update(meal);
                _db.SaveChanges();

                dgv_MealDetails.DataSource = null;
                foods.Add(meal.FoodMeals.Select(x => x.Food).Where(x => x.FoodID == selectedFood.FoodID).FirstOrDefault());
                dgv_MealDetails.DataSource = foods;

            }
            #endregion

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            #region Eski Kısım
            //Food selectedFood = dgv_MealDetails.SelectedCells[0].OwningRow.DataBoundItem as Food;
            //foods.Remove(selectedFood);
            //dgv_MealDetails.DataSource = null;
            //dgv_MealDetails.DataSource = foods;
            //Food? deletedFood = _db.FoodMeals.Select(x => x.Food).Where(x => x.FoodID == selectedFood.FoodID).FirstOrDefault(); 
            #endregion

            #region Yeni Kısım
            using (_db = new())
            {
                Food selectedFood = dgv_MealDetails.SelectedCells[0].OwningRow.DataBoundItem as Food;
                foods.Remove(selectedFood);
                dgv_MealDetails.DataSource = null;
                dgv_MealDetails.DataSource = foods;
                //Food? deletedFood = _db.FoodMeals.Select(x => x.Food).Where(x => x.FoodID == selectedFood.FoodID).FirstOrDefault();
                //_db.Remove(deletedFood);
                FoodMeal? selectedMeal = _db.FoodMeals.Where(x => x.FoodID == selectedFood.FoodID).FirstOrDefault();
                _db.Remove(selectedMeal);
                _db.SaveChanges();
            }

            #endregion

        }

        private void btnAddMeal_Click(object sender, EventArgs e)
        {



            #region Eskiler
            #region Bi şey öğrendim
            //dynamic sonuc = dgv_MealDetails.DataSource;
            //ICollection<Food> foods = sonuc;
            //int selectedMealsID = meal.MealID;
            ///ICollection<Food> Şeklinde yakalayabiliyorum @@@@@@@@@@@@@@@@@@@@@@@
            #endregion
            #region deneme3
            //var result = dgv_MealDetails.DataSource as List<Food>;


            //using (_db = new())
            //{
            //    foreach (var item in result)
            //    {
            //        meal.FoodMeals = new List<FoodMeal>()
            //        {
            //            new FoodMeal()
            //            {
            //                FoodID = item.FoodID

            //            }
            //        };
            //        _db.Update(meal);
            //        _db.SaveChanges();
            //    }


            //} 
            #endregion
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
            #endregion
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //dgv_FoodList.Rows.Clear();

            dgv_FoodList.DataSource = null;
            dgv_FoodList.DataSource = foodListDgv.Where(x => x.FoodName.ToLower().Contains(txtSearch.Text.ToLower())).ToList();
        }
    }
}
