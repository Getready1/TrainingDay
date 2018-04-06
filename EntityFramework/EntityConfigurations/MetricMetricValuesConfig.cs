using DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.EntityConfigurations
{
    public class MetricMetricValuesConfig : IEntityTypeConfiguration<MetricMetricValues>
    {
        public void Configure(EntityTypeBuilder<MetricMetricValues> builder)
        {
            builder.HasKey(x => new { x.MetricId, x.MetricValueId });

            builder.HasOne(x => x.Metric).WithMany(y => y.MetricValues).HasForeignKey(z => z.MetricId);
            //builder.HasOne(x => x.MetricValue).WithMany(y => y.Metrics).HasForeignKey(z => z.MetricValueId);
        }
    }
}
