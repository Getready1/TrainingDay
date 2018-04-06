using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels
{
    public class Metric
    {
        public int MetricId { get; set; }
        public string Name { get; set; }

        public int MetricTypeId { get; set; }
        public MetricType MetricType { get; set; }

        public int? MetricValueId { get; set; }
        public List<MetricMetricValues> MetricValues { get; set; }

        public List<MetricExerciseTemplates> ExerciseTemplates { get; set; }
    }
}
