using DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.EntityConfigurations
{
    public class MetricValueConfig : IEntityTypeConfiguration<MetricValue>
    {
        public void Configure(EntityTypeBuilder<MetricValue> builder)
        {
            builder.HasOne(x => x.Metric).WithOne(y => y.MetricValue).HasForeignKey<Metric>(z => z.MetricValueId);
        }
    }
}
