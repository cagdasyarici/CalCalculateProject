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
        MainFormDeneme mainFormDeneme;
        public AddFoodToMeal(Meal currentMeal, User currentUser, MainFormDeneme CurrentMainFormDeneme)
        {
            InitializeComponent();
            mainFormDeneme = CurrentMainFormDeneme;
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
            dgvFoodList.Columns["CategoryID"].Visible = false;
            dgvFoodList.Columns["FoodMeals"].Visible = false;
            dgvFoodList.Columns["Category"].Visible = false;
            DataGridViewColumn dataGridViewColumn = new DataGridViewColumn();
            dataGridViewColumn.Name = "Category1";
            dataGridViewColumn.HeaderText = "Category";
            dataGridViewColumn.ValueType = typeof(String);
            dataGridViewColumn.CellTemplate = new DataGridViewTextBoxCell();
            
            dgvFoodList.Columns.Add(dataGridViewColumn);
            dgvFoodList.Columns["Category1"].Visible = true;
            int columnIndex = dgvFoodList.Columns["Category1"].Index;
            int categoryID;
            Food food;
            Category category;
            CategoryServices categoryServices = new CategoryServices();
            //for(int i=0; i < dgvFoodList.Rows.Count; i++) 
            //{
            //    food = foodServices.FindEntity((int)dgvFoodList.Rows[i].Cells[0].Value);
            //    categoryID= food.CategoryId;
            //    category = categoryServices.FindEntity(categoryID);
            //    dgvFoodList.Rows[i].Cells[columnIndex].Value = category.CategoryName;


            //}
            dgvFoodList.Rows[0].Cells[columnIndex].Value = "sdfasdf";
            dgvFoodList.Refresh();


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
            Form1 MealForm = new(user, mainFormDeneme);
            MealForm.MdiParent = mainFormDeneme;
            int height = MealForm.Height + 35;
            int width = MealForm.Width + 238;
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
                    MessageBox.Show("Vla aynı food zaten mealın içinde var sen niye bi daha ekliyon. Yanlış gramaj girdiysen eskisini sil doğru gramajla yeniden ekle");
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
