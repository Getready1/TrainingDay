using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataModels
{
    public class MuscleGroup
    {
        public Guid MuscleGroupId { get; set; }
        public string Name { get; set; }

        public Guid MuscleCategoryId { get; set; }
        public MuscleCategory MuscleCategory { get; set; }

        public List<ExerciseCoreMuscleGroup> CoreExcercises { get; set; }
        public List<ExerciseSuppMuscleGroup> SupExcercises { get; set; }
    }
}
