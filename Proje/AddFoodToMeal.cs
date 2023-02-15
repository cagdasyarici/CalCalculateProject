using CalCalculatorBLL;
using CalCalculatorDAL;
using CalCalculatorDAL.Repositories;
using CalCalculatorEntities;
using CalCalculatorEntities.Models;
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

            ListMealRefresh(mealList);





            #endregion



        }

        private void btnAddMealDetail_Click(object sender, EventArgs e)
        {

            #region Yeni Kısım 

            if (CheckGramCount(txtGrams.Text))
            {
                meal.FoodMeals.Clear(); // todo: Çağdaşa bu kısmı sor.Böyle olması sorun çıkarmıyor mu ?

                Food? selectedFood = dgv_FoodList.SelectedCells[0].OwningRow.DataBoundItem as Food;
                FoodServices foodServices = new FoodServices();
                Food food = foodServices.FindEntity(selectedFood.FoodID);
                meal.FoodMeals.Add(new FoodMeal()
                {
                    //MealID = meal.MealID,
                    //FoodID = selectedFood.FoodID, BUNLARA GEREK YOK SANIRIM. DENEME AMAÇLI.
                    //Meal = meal,
                    Food = food,
                    Grams = int.Parse(txtGrams.Text)
                });

                MealServices mealServices = new MealServices();
                mealServices.AttachEntity(meal);

                var mealList = mealServices.ListeOlustur(meal);

                ListMealRefresh(mealList);
            }

            else
            {
                MessageBox.Show("Please enter a proper value", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            //string foodDetail = dgv_MealDetails.SelectedCells[0].OwningRow.DataBoundItem.ToString();

            //int FoodID = Convert.ToInt32((foodDetail[foodDetail.Length - 3]).ToString());

            TempFood tmpFood =  dgv_MealDetails.SelectedCells[0].OwningRow.DataBoundItem as TempFood;
            int FoodID = tmpFood.FoodID;
           

            FoodMealServices foodMealServices = new FoodMealServices();
            
            FoodMeal? selectedFoodMeal2 = foodMealServices.FindFoodMeal(FoodID, meal.MealID);
            foodMealServices.DatabaseRemove(selectedFoodMeal2);
        

            MealServices mealServices = new MealServices();
            var mealList = mealServices.ListeOlustur(meal);

            ListMealRefresh(mealList);

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

        private void ListMealRefresh(List<TempFood> list)
        {
            dgv_MealDetails.DataSource = null;

            dgv_MealDetails.DataSource = list;
            dgv_MealDetails.Columns["FoodID"].Visible = false;
        }

        private bool CheckGramCount(string gram)
        {

            int gramCount = 0;
            bool isGramNumber = int.TryParse(txtGrams.Text,out gramCount);

            if (isGramNumber && gramCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }



        private void btnAddMeal_Click(object sender, EventArgs e)
        {
            double sum = 0;
            for (int i = 0; i < dgv_MealDetails.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dgv_MealDetails.Rows[i].Cells[1].Value);
            }
            meal.TotalCalorie = sum;
            MealServices mealServices = new MealServices();
            mealServices.UpdateEntity(meal);
        }

    }
}
