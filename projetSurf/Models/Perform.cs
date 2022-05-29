using System;
using System.Collections.Generic;

#nullable disable

namespace projetSurf.Models
{
    public partial class Perform
    {
        public Perform(int idMonitors, int idLessons)
        {
            IdMonitors = idMonitors;
            IdLessons = idLessons;
        }

        public int IdMonitors { get; set; }
        public int IdLessons { get; set; }

        public virtual Lesson IdLessonsNavigation { get; set; }
        public virtual Monitor IdMonitorsNavigation { get; set; }
    }
}
