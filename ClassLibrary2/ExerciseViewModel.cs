using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels
{
    public class ExerciseViewModel
    {
        public int ExerciseId { get; set; }
        public string Name { get; set; }
        //public string ImageUrl { get; set; }

        public int TrainingId { get; set; }
        public int ExerciseTemplateId { get; set; }

        public List<SetViewModel> Sets { get; set; }
    }
}
