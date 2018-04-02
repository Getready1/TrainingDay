using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels
{
    public class MetricExerciseTemplates
    {
        public int MetricId { get; set; }
        public Metric Metric { get; set; }

        public int ExerciseTemplateId { get; set; }
        public ExerciseTemplate ExerciseTemplate { get; set; }
    }
}
