using DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.EntityConfigurations
{
    public class TrainingEntityConfig : IEntityTypeConfiguration<Training>
    {
        public void Configure(EntityTypeBuilder<Training> builder)
        {
            builder.HasKey(m => m.TrainingId);
            builder.Property(m => m.TrainingId).ValueGeneratedOnAdd();
            builder.Property(m => m.Name).IsRequired().HasMaxLength(20);
        }
    }
}
