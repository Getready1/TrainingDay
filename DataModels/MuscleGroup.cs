using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataModels
{
    public class MuscleGroup
    {
        public int MuscleGroupId { get; set; }
        public string Name { get; set; }

        public int MuscleCategoryId { get; set; }
        public MuscleCategory MuscleCategory { get; set; }

        public List<ExerciseTemplateCoreMuscleGroups> CoreExcerciseTemplates { get; set; }
        public List<ExerciseTemplateSuppMuscleGroups> SupExcercisesTemplates { get; set; }
    }
}
