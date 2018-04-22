using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels
{
    public class Metric
    {
        public int MetricId { get; set; }
        public string Name { get; set; }
        public double MetricValue { get; set; }

        public int MetricTypeId { get; set; }
        public MetricType MetricType { get; set; }

        public int SetId { get; set; }
        public Set Set { get; set; }
    }
}
