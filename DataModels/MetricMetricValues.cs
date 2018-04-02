using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels
{
    public class MetricMetricValues
    {
        public int MetricId { get; set; }
        public Metric Metric { get; set; }

        public int MetricValueId { get; set; }
        public MetricValue MetricValue { get; set; }
    }
}
