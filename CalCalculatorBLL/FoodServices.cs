﻿using CalCalculatorDAL;
using CalCalculatorDAL.Repositories;
using CalCalculatorEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CalCalculatorBLL
{
    public class FoodServices : BaseRepository<Food>
    {
        CalCalculateDB _db;
        public bool CreateFood(string foodName, int foodCarb, int foodFat, int foodProt, int foodCal, int foodCategoryId)
        {

            using (_db = new CalCalculateDB())
            {
                bool foodCreated = false;
                if (foodName != null || foodName != "")
                {

                    if (!_db.Foods.Select(x => x.FoodName).Contains(foodName))
                    {

                        Food food = new Food
                        {
                            FoodName = foodName,
                            FoodCarb = foodCarb,
                            FoodFat = foodFat,
                            FoodProt = foodProt,
                            FoodCal = foodCal,
                            CategoryId = foodCategoryId
                        };
                        AddEntity(food);
                        return foodCreated = true;

                    }
                    else
                    {
                        return foodCreated = false;
                    }
                }
                else
                {
                    return foodCreated = false;
                }



            }
        }
    }
}
