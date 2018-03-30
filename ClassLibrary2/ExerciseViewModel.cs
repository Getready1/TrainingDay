using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels
{
    public class ExerciseViewModel
    {
        public Guid ExerciseId { get; set; }
        public string Name { get; set; }
        //public string ImageUrl { get; set; }

        public Guid TrainingId { get; set; }
    }
}
