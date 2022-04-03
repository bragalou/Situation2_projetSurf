using System;
using System.Collections.Generic;

#nullable disable

namespace projetSurf.Models
{
    public partial class Use
    {
        public int IdLessons { get; set; }
        public int IdWetsuits { get; set; }

        public virtual Lesson IdLessonsNavigation { get; set; }
        public virtual Wetsuit IdWetsuitsNavigation { get; set; }
    }
}
