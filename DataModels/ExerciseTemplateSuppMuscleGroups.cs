using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels
{
    public class ExerciseTemplateSuppMuscleGroups
    {
        public int ExerciseTemplateId { get; set; }
        public ExerciseTemplate ExerciseTemplate { get; set; }

        public int MuscleGroupId { get; set; }
        public MuscleGroup MuscleGroup { get; set; }
    }
}
