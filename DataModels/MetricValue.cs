using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels
{
    public class MetricValue
    {
        public int MetricValueId { get; set; }
        public double Value { get; set; }

        public int MetricId { get; set; }
        public List<MetricMetricValues> Metrics { get; set; }
    }
}
