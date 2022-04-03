using System;
using System.Collections.Generic;

#nullable disable

namespace projetSurf.Models
{
    public partial class Student
    {
        public Student()
        {
            Dos = new HashSet<Do>();
        }

        public int IdClients { get; set; }
        public DateTime DateBirthStudents { get; set; }
        public string PhoneStudents { get; set; }
        public string PostalCodeStudents { get; set; }
        public string NameClients { get; set; }
        public string FirstnameClients { get; set; }

        public virtual Client IdClientsNavigation { get; set; }
        public virtual ICollection<Do> Dos { get; set; }
    }
}
