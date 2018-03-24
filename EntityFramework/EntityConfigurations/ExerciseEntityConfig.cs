using DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.EntityConfigurations
{
    public class ExerciseEntityConfig : IEntityTypeConfiguration<Exercise>
    {
        public void Configure(EntityTypeBuilder<Exercise> builder)
        {
            builder.HasKey(m => m.ExerciseId);
            builder.Property(m => m.ExerciseId).ValueGeneratedOnAdd();
            builder.Property(m => m.Name).IsRequired().HasMaxLength(20);
        }
    }
}
