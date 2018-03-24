using DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.EntityConfigurations
{
    public class MuscleCategoryEntityConfig : IEntityTypeConfiguration<MuscleCategory>
    {
        public void Configure(EntityTypeBuilder<MuscleCategory> builder)
        {
            builder.HasKey(m => m.MuscleCategoryId);
            builder.Property(m => m.MuscleCategoryId).ValueGeneratedOnAdd();
            builder.Property(m => m.Name).IsRequired().HasMaxLength(20);
        }
    }
}
