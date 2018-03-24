using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels
{
    public class TrainingMuscleCategories
    {
        public Guid TrainingId { get; set; }
        public Training Training { get; set; }

        public Guid MuscleCategoryId { get; set; }
        public MuscleCategory MuscleCategory { get; set; }
    }
}
