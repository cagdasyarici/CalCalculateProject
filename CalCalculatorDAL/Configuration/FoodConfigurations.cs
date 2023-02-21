using CalCalculatorEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculatorDAL.Configuration
{
    public class FoodConfigurations : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.Property(x => x.FoodName)
                   .IsRequired()
                   .HasMaxLength(50);


            builder.HasOne(x => x.Category)
                   .WithMany(x => x.Foods)
                   .HasForeignKey(x => x.CategoryId);
        }

        
    }
}
