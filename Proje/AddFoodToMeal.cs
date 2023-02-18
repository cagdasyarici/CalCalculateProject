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
        CalCalculateDB _db;


        IList<Food> foodListDgv;
        Meal meal;
        User user;
        MainForm mainFormDeneme;
        FlowLayoutPanel sideBarContainer;
        public AddFoodToMeal(Meal currentMeal, User currentUser, MainForm CurrentMainFormDeneme,FlowLayoutPanel currentSideBarContainer)
        {
            InitializeComponent();
            mainFormDeneme = CurrentMainFormDeneme;
            meal = currentMeal;
            user = currentUser;
            sideBarContainer = currentSideBarContainer;
            txtGrams.Text = "0";
            
        }

        private void AddFoodToMeal_Load(object sender, EventArgs e)
        {


            #region Dgv2 Doldurma
            FoodServices foodServices = new FoodServices();


            foodListDgv = foodServices.BringTList();
            dgvFoodList.DataSource = foodListDgv;
            dgvFoodList.Columns["CategoryID"].Visible = false;
            dgvFoodList.Columns["FoodMeals"].Visible = false;
            dgvFoodList.Columns["Category"].Visible = false;
            //DataGridViewColumn dataGridViewColumn = new DataGridViewColumn();
            //dataGridViewColumn.Name = "Category1";
            //dataGridViewColumn.HeaderText = "Category";
            //dataGridViewColumn.ValueType = typeof(String);
            //dataGridViewColumn.CellTemplate = new DataGridViewTextBoxCell();
            //dgvFoodList.Columns.Add(dataGridViewColumn);
            //dgvFoodList.Rows[0].Cells[4].Value = "değer";



            #endregion



            #region Dgv1 Doldurma



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

            dgvFoodList.DataSource = null;
            dgvFoodList.DataSource = foodListDgv.Where(x => x.FoodName.ToLower().Contains(txtSearch.Text.ToLower())).ToList();
            dgvFoodList.Columns["CategoryID"].Visible = false;
            dgvFoodList.Columns["FoodMeals"].Visible = false;
            dgvFoodList.Columns["Category"].Visible = false;
        }

        private void ListMealRefresh(List<TempFood> list)
        {
            dgvMealDetails.DataSource = null;

            dgvMealDetails.DataSource = list;
            dgvMealDetails.Columns["FoodID"].Visible = false;
        }


        /// <summary>
        /// tring girilen gram değerinin bir sayı olduğunu,sıfırdan büyük olduğunu ve integer sınırları içerisi olduğunu kontrol eder
        /// </summary>
        /// <param name="gram"></param>
        /// <returns>Girilen string cinsinden gram değeri bu şartları sağlıyorsa True,sağlamıyorsa False döner</returns>
        private bool CheckGramCount(string gram)
        {
            int gramCount = 0;
            bool isGramNumber = int.TryParse(txtGrams.Text, out gramCount);

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

        }

        private void ıconButton1_Click(object sender, EventArgs e) // todo:İsmi düzelt
        {
            MealForm MealForm = new(user, mainFormDeneme,sideBarContainer);
            MealForm.MdiParent = mainFormDeneme;
            int height = MealForm.Height + 35;
            int width = MealForm.Width + sideBarContainer.Width + 6;
            mainFormDeneme.Size = new Size(width, height);
            MealForm.Show();
            this.Close();
        }

        private void btnAddMealDetails_Click(object sender, EventArgs e)  // todo:2 tane food eklenince hata veriyor 
        {
            #region Yeni Kısım 
            MealServices mealServices = new MealServices();
            if (CheckGramCount(txtGrams.Text))
            {
                Food? selectedFood = dgvFoodList.SelectedCells[0].OwningRow.DataBoundItem as Food;
                FoodServices foodServices = new FoodServices();
                Food food = foodServices.FindEntity(selectedFood.FoodID); // todo:Bu kodun amacı nedir ? Buraya tekrar bak

                /// buraya başka food var mı kontrolü yapıcam
             
                    meal.FoodMeals.Add(new FoodMeal()
                    {
                        //MealID = meal.MealID,
                        //FoodID = selectedFood.FoodID, BUNLARA GEREK YOK SANIRIM. DENEME AMAÇLI.
                        //Meal = meal,
                        Food = food,
                        Grams = int.Parse(txtGrams.Text)


                    });

                bool foodCreated;
                foodCreated = mealServices.AttachEntity(meal);
                if (foodCreated==true)
                {
                    var mealList = mealServices.ListeOlustur(meal);

                    ListMealRefresh(mealList);
                    double sum = 0;
                    for (int i = 0; i < dgvMealDetails.Rows.Count; ++i)
                    {
                        sum += Convert.ToInt32(dgvMealDetails.Rows[i].Cells[1].Value);
                    }
                    meal.TotalCalorie = sum;

                    mealServices.UpdateEntity(meal);
                }
                else
                {
                    MessageBox.Show("This food is already exists.");
                }
                    
   
             
            }

            else
            {
                MessageBox.Show("Please enter a proper value", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

            #endregion
        }

        private void btnDeleteMeals_Click(object sender, EventArgs e)
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
                    double sum = 0;
                    for (int i = 0; i < dgvMealDetails.Rows.Count; ++i)
                    {
                        sum += Convert.ToInt32(dgvMealDetails.Rows[i].Cells[1].Value);
                    }
                    meal.TotalCalorie = sum;

                    mealServices.UpdateEntity(meal);
               

                
            }
            catch (ArgumentOutOfRangeException)
            {

                MessageBox.Show("Please,choose a food to delete from Meal Details Table");
            }

            catch (Exception)
            {

                MessageBox.Show("Error", "", MessageBoxButtons.OK, MessageBoxIcon.Error); //todo: daha sonra uygun bi yazı düşün (yuşa)
            }
            

            #endregion
        }

        /// <summary>
        /// Seçilen Food'un Meal Detail Listesinde Olup olmaığını kontrol eder
        /// </summary>
        /// <param name="selectedFood"></param>
        /// <param name="selectedMeal"></param>
        /// <returns>Food listede zaten mevcutsa True,Değilse False döndürür</returns>
        public bool CheckIsFoodNameExist(Food selectedFood)
        {
            using (_db = new())
            {
                var item1 = dgvMealDetails.DataSource as List<TempFood>;
                return true;
            }

        }
    }
}
