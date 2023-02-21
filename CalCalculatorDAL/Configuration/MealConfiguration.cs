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
    public class MealConfiguration : IEntityTypeConfiguration<Meal>
    {
        public void Configure(EntityTypeBuilder<Meal> builder)
        {
            builder.HasKey(x => x.MealID);

            builder.HasOne(x => x.User)
                   .WithMany(x => x.Meals)
                   .HasForeignKey(x => x.ContactUserID);

            builder.Property(x => x.MealName)
                   .IsRequired()
                   .HasMaxLength(50);
        }
    }
}
