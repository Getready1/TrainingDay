using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels
{
    public class Exercise
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public string Comment { get; set; }

        public Guid TrainingId { get; set; }
        public TrainingViewModel Training { get; set; }

        public List<MuscleGroup> CoreMuscleGroups { get; set; }
        public List<MuscleGroup> SupplimentaryMuscleGroups { get; set; }

        public List<Set> Sets { get; set; }
    }
}
