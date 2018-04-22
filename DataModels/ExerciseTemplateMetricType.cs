using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels
{
    public class ExerciseTemplateMetricType
    {
        public int MetricTypeId { get; set; }
        public MetricType MetricType { get; set; }

        public int ExerciseTemplateId { get; set; }
        public ExerciseTemplate ExerciseTemplate { get; set; }
    }
}
