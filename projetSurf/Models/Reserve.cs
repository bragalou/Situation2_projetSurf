using System;
using System.Collections.Generic;

#nullable disable

namespace projetSurf.Models
{
    public partial class Reserve
    {
        public int IdLessons { get; set; }
        public int IdBoards { get; set; }

        public virtual Board IdBoardsNavigation { get; set; }
        public virtual Lesson IdLessonsNavigation { get; set; }
    }
}
