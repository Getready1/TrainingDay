using DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.EntityConfigurations
{
    public class MetricExerciseTemplatesConfig : IEntityTypeConfiguration<MetricExerciseTemplates>
    {
        public void Configure(EntityTypeBuilder<MetricExerciseTemplates> builder)
        {
            builder.HasKey(x => new { x.ExerciseTemplateId, x.MetricId });

            builder.HasOne(x => x.ExerciseTemplate).WithMany(y => y.Metrics).HasForeignKey(z => z.ExerciseTemplateId);
            builder.HasOne(x => x.Metric).WithMany(y => y.ExerciseTemplates).HasForeignKey(z => z.MetricId);
        }
    }
}
