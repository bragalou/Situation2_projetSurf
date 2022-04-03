using System;
using System.Collections.Generic;

#nullable disable

namespace projetSurf.Models
{
    public partial class Board
    {
        public Board()
        {
            Rents = new HashSet<Rent>();
            Reserves = new HashSet<Reserve>();
        }

        public int IdBoards { get; set; }
        public string BrandBoards { get; set; }
        public DateTime DatePurchaseBoards { get; set; }
        public string StateBoards { get; set; }
        public string SizeBoards { get; set; }
        public float PriceRent1HourBoards { get; set; }

        public virtual ICollection<Rent> Rents { get; set; }
        public virtual ICollection<Reserve> Reserves { get; set; }
    }
}
