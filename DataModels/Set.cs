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
        public Metrics Metrics { get; set; }
        public Difficulty Difficulty { get; set; }

        public int ExericeId { get; set; }
        public Exercise Exercise { get; set; }

        public List<MetricValue> MetricValues { get; set; }
    }
}
