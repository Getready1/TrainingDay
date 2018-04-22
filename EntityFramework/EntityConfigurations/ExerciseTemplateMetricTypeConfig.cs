
using DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.EntityConfigurations
{
    public class ExerciseTemplateMetricTypeConfig : IEntityTypeConfiguration<ExerciseTemplateMetricType>
    {
        public ExerciseTemplateMetricTypeConfig()
        {
        }

        public void Configure(EntityTypeBuilder<ExerciseTemplateMetricType> builder)
        {
            builder.HasKey(x => new { x.MetricTypeId, x.ExerciseTemplateId });

            builder.HasOne(x => x.MetricType).WithMany(y => y.ExerciseTemplates).HasForeignKey(z => z.MetricTypeId);
            builder.HasOne(x => x.ExerciseTemplate).WithMany(y => y.MetricTypes).HasForeignKey(z => z.ExerciseTemplateId);
        }
    }
}
