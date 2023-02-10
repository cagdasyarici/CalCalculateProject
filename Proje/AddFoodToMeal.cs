using CalCalculatorBLL;
using CalCalculatorDAL;
using CalCalculatorDAL.Repositories;

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



        IList<Food> foodListDgv;
        Meal meal;
        public AddFoodToMeal(Meal currentMeal)
        {
            InitializeComponent();
            meal = currentMeal;
            txtGrams.Text = "0";
        }

        private void AddFoodToMeal_Load(object sender, EventArgs e)
        {


            #region Dgv2 Doldurma
            FoodServices foodServices = new FoodServices();


            foodListDgv = foodServices.BringTList();
            dgv_FoodList.DataSource = foodListDgv;

            #endregion



            #region Dgv1 Doldurma



            MealServices mealServices = new MealServices();

            var mealList = mealServices.ListeOlustur(meal);

            //foreach (var IdNumber in tempList1)
            //{
            //    foods.Add(_db.Foods.Where(x => x.FoodID == IdNumber).FirstOrDefault());
            //}





            #endregion



        }

        private void btnAddMealDetail_Click(object sender, EventArgs e)
        {

            #region Yeni Kısım 



            Food? selectedFood = dgv_FoodList.SelectedCells[0].OwningRow.DataBoundItem as Food;
            meal.FoodMeals.Add(new FoodMeal()
            {
                Food = selectedFood,
                Grams = int.Parse(txtGrams.Text)
            });

            MealServices mealServices = new MealServices();
            mealServices.UpdateEntity(meal);

            var mealList = mealServices.ListeOlustur(meal);

            ListMealRefresh(mealList);





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

            string foodDetail = dgv_MealDetails.SelectedCells[0].OwningRow.DataBoundItem.ToString();

            int FoodID = Convert.ToInt32((foodDetail[foodDetail.Length - 3]).ToString());

            FoodMealServices foodMealServices = new FoodMealServices();

            FoodMeal? selectedFoodMeal = foodMealServices.FindFoodMeal(FoodID, meal.MealID);

            foodMealServices.RemoveEntity(selectedFoodMeal);

            MealServices mealServices = new MealServices();
            var mealList = mealServices.ListeOlustur(meal);

            meal.FoodMeals.Remove(selectedFoodMeal);

            ListMealRefresh(mealList);

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

        private void ListMealRefresh(dynamic list)
        {
            dgv_MealDetails.DataSource = null;

            dgv_MealDetails.DataSource = list;
            dgv_MealDetails.Columns["FoodID"].Visible = false;
        }
    }
}
