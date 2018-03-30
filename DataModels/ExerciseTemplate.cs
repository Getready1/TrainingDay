using DataModels.ComplexModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels
{
    public class ExerciseTemplate
    {
        public Guid ExerciseTemplateId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<ExerciseTemplateCoreMuscleGroups> CoreMuscleGroups { get; set; }
        public List<ExerciseTemplateSuppMuscleGroups> SupplimentaryMuscleGroups { get; set; }
        public List<Metric> Metrics { get; set; }
    }
}
