using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels
{
    public class ExerciseCoreMuscleGroup
    {
        public Guid ExcersiceId { get; set; }
        public Exercise Exercise { get; set; }

        public Guid MuscleGroupId { get; set; }
        public MuscleGroup MuscleGroup { get; set; }
    }
}
