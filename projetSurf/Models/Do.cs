using System;
using System.Collections.Generic;

#nullable disable

namespace projetSurf.Models
{
    public partial class Do
    {
        public int IdLessons { get; set; }
        public int IdClients { get; set; }

        public virtual Student IdClientsNavigation { get; set; }
        public virtual Lesson IdLessonsNavigation { get; set; }
    }
}
