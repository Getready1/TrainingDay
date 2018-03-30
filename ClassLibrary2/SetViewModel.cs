using DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels
{
    public class SetViewModel
    {
        public Guid Id { get; set; }
        public Guid ExerciseId { get; set; }
        public List<MetricValueViewModel> MetricValues { get; set; }
    }
}
