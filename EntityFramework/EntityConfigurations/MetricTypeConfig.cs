using DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.EntityConfigurations
{
    public class MetricTypeConfig : IEntityTypeConfiguration<MetricType>
    {
        public void Configure(EntityTypeBuilder<MetricType> builder)
        {
            throw new NotImplementedException();
        }
    }
}
