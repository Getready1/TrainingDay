using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels
{
    public class MetricType
    {
        public int MetricTypeId { get; set; }
        public string Name { get; set; }

        public List<ExerciseTemplateMetricType> ExerciseTemplates { get; set; }
    }
}
