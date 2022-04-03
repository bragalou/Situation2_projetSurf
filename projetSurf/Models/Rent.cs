using System;
using System.Collections.Generic;

#nullable disable

namespace projetSurf.Models
{
    public partial class Rent
    {
        public int IdBoards { get; set; }
        public int IdClients { get; set; }
        public DateTime DateStartRent { get; set; }
        public DateTime DateEndRent { get; set; }

        public virtual Board IdBoardsNavigation { get; set; }
        public virtual Client IdClientsNavigation { get; set; }
    }
}
