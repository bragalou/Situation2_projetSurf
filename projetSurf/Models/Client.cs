using System;
using System.Collections.Generic;

#nullable disable

namespace projetSurf.Models
{
    public partial class Client
    {
        public Client()
        {
            Rents = new HashSet<Rent>();
        }
        public Client(string nameClients, string firstnameClients)
        {
            NameClients = nameClients;
            FirstnameClients = firstnameClients;
        }

        public Client(int idClients, string nameClients, string firstnameClients)
            :this (nameClients, firstnameClients)
        {
            IdClients = idClients;
        }

        public int IdClients { get; set; }
        public string NameClients { get; set; }
        public string FirstnameClients { get; set; }

        public virtual Student Student { get; set; }
        public virtual ICollection<Rent> Rents { get; set; }
    }
}
