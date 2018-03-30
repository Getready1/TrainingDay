using DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels
{
    public class TrainingViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public DateTime CreationDate { get; set; }

        public List<ExerciseViewModel> Exercises { get; set; }
        public List<MuscleCategoryViewModel> MuscleCategories { get; set; }
    }
}
