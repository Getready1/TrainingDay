using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;

namespace DataModels
{
    public class Training
    {
        public Guid TrainingId { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public List<Exercise> Exercises { get; set; }
        public List<TrainingMuscleCategories> MuscleCategories { get; set; }
    }
}
