using Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels
{
    public class Set
    {
        public int Id { get; set; }
        public double Weight { get; set; }
        public double Duration { get; set; }
        public double Distance { get; set; }
        public int Repetitions { get; set; }
        public Difficulty Difficulty { get; set; }

        public Guid ExericeId { get; set; }
        public Exercise Exercise { get; set; }
    }
}
