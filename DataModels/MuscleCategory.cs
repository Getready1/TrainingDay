using System;
using System.Collections.Generic;

namespace DataModels
{
    public class MuscleCategory
    {
        public Guid MuscleCategoryId { get; set; }
        public string Name { get; set; }

        public List<MuscleGroup> MuscleGroups { get; set; }
        public List<TrainingMuscleCategories> Trainings { get; set; }
    }
}
