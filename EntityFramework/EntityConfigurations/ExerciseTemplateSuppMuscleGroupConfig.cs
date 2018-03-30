using DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.EntityConfigurations
{
    public class ExerciseTemplateSuppMuscleGroupConfig : IEntityTypeConfiguration<ExerciseTemplateSuppMuscleGroups>
    {
        public void Configure(EntityTypeBuilder<ExerciseTemplateSuppMuscleGroups> builder)
        {
            builder.HasKey(m => new { m.ExerciseTemplateId, m.MuscleGroupId });

            builder.HasOne(x => x.ExerciseTemplate).WithMany(y => y.SupplimentaryMuscleGroups).HasForeignKey(z => z.ExerciseTemplateId);
            builder.HasOne(x => x.MuscleGroup).WithMany(y => y.SupExcercisesTemplates).HasForeignKey(z => z.MuscleGroupId);
        }
    }
}
