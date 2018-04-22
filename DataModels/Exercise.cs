using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataModels
{
    public class Exercise
    {
        public int ExerciseId { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }

        public int TrainingId { get; set; }
        public Training Training { get; set; }

        public List<Set> Sets { get; set; }

        public int ExerciseTemplateId { get; set; }
        public ExerciseTemplate ExerciseTemplate { get; set; }
    }
}
