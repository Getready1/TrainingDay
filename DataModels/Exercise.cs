using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataModels
{
    public class Exercise
    {
        public Guid ExerciseId { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }

        public Guid TrainingId { get; set; }
        public Training Training { get; set; }

        public List<ExerciseCoreMuscleGroup> CoreMuscleGroups { get; set; }
        public List<ExerciseSuppMuscleGroup> SupplimentaryMuscleGroups { get; set; }
        public List<Set> Sets { get; set; }
    }
}
