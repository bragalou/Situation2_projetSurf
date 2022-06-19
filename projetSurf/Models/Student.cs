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

        public Student(int idClients, string firstnameClients, string nameClients, string phoneStudents, string postalCodeStudents, DateTime dateBirthStudents)
        {
            IdClients = idClients;
            DateBirthStudents = dateBirthStudents;
            PhoneStudents = phoneStudents;
            PostalCodeStudents = postalCodeStudents;
            NameClients = nameClients;
            FirstnameClients = firstnameClients;
        }
        public Student(int idClients, string firstnameClients, string nameClients, string phoneStudents, string postalCodeStudents, DateTime dateBirthStudents, string mailStudents)
            :this (idClients, firstnameClients, nameClients, phoneStudents, postalCodeStudents, dateBirthStudents)
        {
            FirstnameClients = firstnameClients;
        }

        public int IdClients { get; set; }
        public DateTime DateBirthStudents { get; set; }
        public string PhoneStudents { get; set; }
        public string PostalCodeStudents { get; set; }
        public string NameClients { get; set; }
        public string FirstnameClients { get; set; }
        public string MailStudents { get; set; }

        public virtual Client IdClientsNavigation { get; set; }
        public virtual ICollection<Do> Dos { get; set; }
    }
}
