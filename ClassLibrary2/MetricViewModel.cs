using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels
{
    public class MetricViewModel
    {
        public int MetricId { get; set; }
        public string Name { get; set; }
        public double MetricValue { get; set; }
        public int MetricTypeId { get; set; }
        public int SetId { get; set; }
    }
}
