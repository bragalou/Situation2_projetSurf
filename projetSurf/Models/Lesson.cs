using System;
using System.Collections.Generic;

#nullable disable

namespace projetSurf.Models
{
    public partial class Lesson
    {
        public Lesson()
        {
            Dos = new HashSet<Do>();
            Performs = new HashSet<Perform>();
            Reserves = new HashSet<Reserve>();
            Uses = new HashSet<Use>();
        }

        public int IdLessons { get; set; }
        public DateTime DateStartLessons { get; set; }
        public string DayLessons { get; set; }
        public int NumberLessons { get; set; }
        public float StartHourLessons { get; set; }
        public float DurationLessons { get; set; }
        public int NmbMaxLessons { get; set; }
        public float PriceLessons { get; set; }
        public string LevelLessons { get; set; }

        public virtual ICollection<Do> Dos { get; set; }
        public virtual ICollection<Perform> Performs { get; set; }
        public virtual ICollection<Reserve> Reserves { get; set; }
        public virtual ICollection<Use> Uses { get; set; }
    }
}
