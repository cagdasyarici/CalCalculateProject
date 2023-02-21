using CalCalculatorEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CalCalculatorDAL.Configuration
{
    public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.UserID);

            builder.HasIndex(p => p.UserName)
                   .IsUnique();

            builder.HasIndex(p => p.Email)
                   .IsUnique();

            builder.Property(x => x.UserName)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(x => x.Password)
                   .IsRequired()
                   .HasMaxLength(16);

            builder.Property(x => x.Email)
                   .IsRequired()
                   .HasMaxLength(50);
            
        }
    }
}
