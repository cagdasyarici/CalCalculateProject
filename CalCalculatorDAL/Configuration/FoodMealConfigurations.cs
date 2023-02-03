using CalCalculatorEntities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculatorDAL.Configuration
{
    internal class FoodMealConfigurations : IEntityTypeConfiguration<FoodMeal>
    {
        public void Configure(EntityTypeBuilder<FoodMeal> builder)
        {
            builder.HasOne(x => x.Food).WithMany(x => x.FoodMeals).HasForeignKey(x => x.FoodID);
            builder.HasOne(x => x.Meal).WithMany(x => x.FoodMeals).HasForeignKey(x => x.MealID);
        }
    }
}
