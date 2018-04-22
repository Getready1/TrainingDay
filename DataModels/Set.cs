using Common;
using DataModels.ComplexModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataModels
{
    public class Set
    {
        public int SetId { get; set; }
        public Difficulty Difficulty { get; set; }

        public int ExerciseId { get; set; }
        public Exercise Exercise { get; set; }

        public List<Metric> Metrics { get; set; }
    }
}
