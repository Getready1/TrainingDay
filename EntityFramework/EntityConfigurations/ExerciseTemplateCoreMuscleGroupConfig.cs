using DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.EntityConfigurations
{
    public class ExerciseTemplateCoreMuscleGroupConfig : IEntityTypeConfiguration<ExerciseTemplateCoreMuscleGroups>
    {
        public void Configure(EntityTypeBuilder<ExerciseTemplateCoreMuscleGroups> builder)
        {
            builder.HasKey(m => new { m.ExerciseTemplateId, m.MuscleGroupId });

            builder.HasOne(x => x.ExerciseTemplate).WithMany(y => y.CoreMuscleGroups).HasForeignKey(z => z.ExerciseTemplateId);
            builder.HasOne(x => x.MuscleGroup).WithMany(y => y.CoreExcerciseTemplates).HasForeignKey(z => z.MuscleGroupId);
        }
    }
}
