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
        User user;
        public AddFoodToMeal(Meal currentMeal,User currentUser)
        {
            InitializeComponent();
            meal = currentMeal;
            user = currentUser;
            txtGrams.Text = "0";
        }

        private void AddFoodToMeal_Load(object sender, EventArgs e)
        {


            #region Dgv2 Doldurma
            FoodServices foodServices = new FoodServices();


            foodListDgv = foodServices.BringTList();
            dgvFoodList.DataSource = foodListDgv;

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
                meal.FoodMeals.Clear(); // todo: Çağdaşa bu kısmı sor.Böyle olması sorun çıkarmıyor mu ?(Yuşa)

                Food? selectedFood = dgvFoodList.SelectedCells[0].OwningRow.DataBoundItem as Food;
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

            #region Yeni Kısım
            //string foodDetail = dgv_MealDetails.SelectedCells[0].OwningRow.DataBoundItem.ToString();

            //int FoodID = Convert.ToInt32((foodDetail[foodDetail.Length - 3]).ToString());


            try
            {
                TempFood? tmpFood = dgvMealDetails.SelectedCells[0].OwningRow.DataBoundItem as TempFood;
                int FoodID = 0;


                FoodID = tmpFood.FoodID;

                FoodMealServices foodMealServices = new FoodMealServices();

                FoodMeal? selectedFoodMeal2 = foodMealServices.FindFoodMeal(FoodID, meal.MealID);
                foodMealServices.DatabaseRemove(selectedFoodMeal2);


                MealServices mealServices = new MealServices();
                var mealList = mealServices.ListeOlustur(meal);

                ListMealRefresh(mealList);
            }
            catch (ArgumentOutOfRangeException)
            {

                MessageBox.Show("Please,choose a food to delete from Meal Details Table");
            }
          
            catch (Exception)
            {

                MessageBox.Show("Error","",MessageBoxButtons.OK,MessageBoxIcon.Error); //todo: daha sonra uygun bi yazı düşün (yuşa)
            }
          
           
            #endregion

        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //dgv_FoodList.Rows.Clear();

            dgvFoodList.DataSource = null;
            dgvFoodList.DataSource = foodListDgv.Where(x => x.FoodName.ToLower().Contains(txtSearch.Text.ToLower())).ToList();
        }

        private void ListMealRefresh(List<TempFood> list)
        {
            dgvMealDetails.DataSource = null;

            dgvMealDetails.DataSource = list;
            dgvMealDetails.Columns["FoodID"].Visible = false;
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



        private void btnAddMeal_Click(object sender, EventArgs e) // todo: Deniz Sanırım ben bunun buttonunu sildim (Yuşa)
        {
            double sum = 0;
            for (int i = 0; i < dgvMealDetails.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dgvMealDetails.Rows[i].Cells[1].Value);
            }
            meal.TotalCalorie = sum;
            MealServices mealServices = new MealServices();
            mealServices.UpdateEntity(meal);
        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            Form1 frm = new(user);
            frm.Show();
            this.Close();

        }
    }
}
