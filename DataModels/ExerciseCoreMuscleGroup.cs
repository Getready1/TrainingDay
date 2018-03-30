using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels
{
    public class ExerciseCoreMuscleGroup
    {
        public int ExcersiceId { get; set; }
        public Exercise Exercise { get; set; }

        public int MuscleGroupId { get; set; }
        public MuscleGroup MuscleGroup { get; set; }
    }
}
