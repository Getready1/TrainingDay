using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels
{
    public class ExerciseTemplateViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl  => "SomeImagUrl";

        public List<MuscleGroupViewModel> CoreMuscleGroups { get; set; }
        public List<MuscleGroupViewModel> SupplimentaryMuscleGroups { get; set; }
        public List<MetricViewModel> Metrics { get; set; }
    }
}
