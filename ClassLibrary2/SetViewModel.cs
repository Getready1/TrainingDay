using DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels
{
    public class SetViewModel
    {
        public int Id { get; set; }
        public int ExerciseId { get; set; }
        public List<MetricValueViewModel> MetricValues { get; set; }
    }
}
