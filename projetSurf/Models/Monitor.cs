using System;
using System.Collections.Generic;

#nullable disable

namespace projetSurf.Models
{
    public partial class Monitor
    {
        public Monitor()
        {
            Performs = new HashSet<Perform>();
        }

        public string CompletName
        {
            get { return FirstnameMonitors + " " +NameMonitors; }
        }

        public Monitor(string nameMonitors, string firstnameMonitors, DateTime dateBirthMonitors, string phoneMonitor, bool administratorMonitor)
        {
            NameMonitors = nameMonitors;
            FirstnameMonitors = firstnameMonitors;
            DateBirthMonitors = dateBirthMonitors;
            PhoneMonitor = phoneMonitor;
            AdministratorMonitor = administratorMonitor;
        }

        public Monitor(string nameMonitors, string firstnameMonitors, DateTime dateBirthMonitors, string phoneMonitor, bool administratorMonitor, string passwordMonitor, string loginMonitor)
            : this(nameMonitors, firstnameMonitors, dateBirthMonitors, phoneMonitor, administratorMonitor)
        {
            PasswordMonitor = passwordMonitor;
            LoginMonitor = loginMonitor;
        }

        public int IdMonitors { get; set; }
        public string NameMonitors { get; set; }
        public string FirstnameMonitors { get; set; }
        public DateTime DateBirthMonitors { get; set; }
        public string PhoneMonitor { get; set; }
        public bool AdministratorMonitor { get; set; }
        public string PasswordMonitor { get; set; }
        public string LoginMonitor { get; set; }

        public virtual ICollection<Perform> Performs { get; set; }
    }
}
