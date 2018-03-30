using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels
{
    public class TrainingMuscleCategories
    {
        public int TrainingId { get; set; }
        public Training Training { get; set; }

        public int MuscleCategoryId { get; set; }
        public MuscleCategory MuscleCategory { get; set; }
    }
}
