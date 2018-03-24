using DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.EntityConfigurations
{
    public class ExerciseCoreMuscleGroupEntityConfig : IEntityTypeConfiguration<ExerciseCoreMuscleGroup>
    {
        public void Configure(EntityTypeBuilder<ExerciseCoreMuscleGroup> builder)
        {
            builder.HasKey(m => new { m.ExcersiceId, m.MuscleGroupId });

            builder.HasOne(x => x.Exercise).WithMany(y => y.CoreMuscleGroups).HasForeignKey(z => z.ExcersiceId);
            builder.HasOne(x => x.MuscleGroup).WithMany(y => y.CoreExcercises).HasForeignKey(z => z.MuscleGroupId);
        }
    }
}
