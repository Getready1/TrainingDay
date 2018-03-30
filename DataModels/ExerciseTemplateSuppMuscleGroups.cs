using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels
{
    public class ExerciseTemplateSuppMuscleGroups
    {
        public Guid ExerciseTemplateId { get; set; }
        public ExerciseTemplate ExerciseTemplate { get; set; }

        public Guid MuscleGroupId { get; set; }
        public MuscleGroup MuscleGroup { get; set; }
    }
}
