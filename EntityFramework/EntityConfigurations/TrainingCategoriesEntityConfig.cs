using DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.EntityConfigurations
{
    public class TrainingCategoriesEntityConfig : IEntityTypeConfiguration<TrainingMuscleCategories>
    {
        public void Configure(EntityTypeBuilder<TrainingMuscleCategories> builder)
        {
            builder.HasKey(m => new { m.MuscleCategoryId, m.TrainingId });

            builder.HasOne(m => m.Training).WithMany(m => m.MuscleCategories).HasForeignKey(z => z.TrainingId);
            builder.HasOne(m => m.MuscleCategory).WithMany(m => m.Trainings).HasForeignKey(z => z.MuscleCategoryId);
        }
    }
}
