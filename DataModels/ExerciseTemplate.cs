using DataModels.ComplexModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels
{
    public class ExerciseTemplate
    {
        public int ExerciseTemplateId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<ExerciseTemplateCoreMuscleGroups> CoreMuscleGroups { get; set; }
        public List<ExerciseTemplateSuppMuscleGroups> SupplimentaryMuscleGroups { get; set; }

        public List<ExerciseTemplateMetricType> MetricTypes { get; set; }
        public List<Exercise> Exercises { get; set; }
    }
}
