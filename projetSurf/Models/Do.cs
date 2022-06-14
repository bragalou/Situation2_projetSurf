using System;
using System.Collections.Generic;

#nullable disable

namespace projetSurf.Models
{
    public partial class Do
    {
        public Do(int idLessons, int idClients)
        {
            IdLessons = idLessons;
            IdClients = idClients;
        }

        public int IdLessons { get; set; }
        public int IdClients { get; set; }

        public virtual Student IdClientsNavigation { get; set; }
        public virtual Lesson IdLessonsNavigation { get; set; }
    }
}
