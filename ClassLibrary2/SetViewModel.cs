using DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels
{
    public class SetViewModel
    {
        public int SetId { get; set; }
        public Difficulty Difficulty { get; set; }
        public int ExerciseId { get; set; }
        public List<MetricViewModel> Metrics { get; set; }
    }
}
