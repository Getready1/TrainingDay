using DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.EntityConfigurations
{
    //public class ExerciseSuppMuscleGroupEntityConfig : IEntityTypeConfiguration<ExerciseSuppMuscleGroup>
    //{
    //    public void Configure(EntityTypeBuilder<ExerciseSuppMuscleGroup> builder)
    //    {
    //        builder.HasKey(m => new { m.ExcersiceId, m.MuscleGroupId });

    //        builder.HasOne(x => x.Exercise).WithMany(y => y.SupplimentaryMuscleGroups).HasForeignKey(z => z.ExcersiceId);
    //        builder.HasOne(x => x.MuscleGroup).WithMany(y => y.SupExcercises).HasForeignKey(z => z.MuscleGroupId);
    //    }
    //}
}
