using Microsoft.EntityFrameworkCore;
using projetSurf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetSurf.Manager
{
    class MonitorManager : Manager
    {
        // ----- ADD -----
        public Monitor AddMonitor(Monitor monitor)
        {
            //ajouter le produit à l'orm ef
            Context.Monitors.Add(monitor);
            //valider les changements dnas la bd
            if (Context.SaveChanges() > 0)
                return monitor;
            return null;
        }

        // ----- DELETE -----
        public bool DeleteMonitor(Monitor monitor)
        {
            if (monitor != null)
            {
                Context.Monitors.Remove(monitor);
                return (Context.SaveChanges() > 0);
            }
            return false;
        }
        public bool DeleteMonitor(int id)
        {
            Monitor monitor = FindMonitor(id);
            if (monitor == null)
                return false;
            return DeleteMonitor(monitor);
        }

        // ----- EDIT -----
        public bool EditMonitor(Monitor monitor)
        {
            //mettre le status de l'entité à modifier dans l'orm
            Context.Entry(monitor).State = EntityState.Modified;
            //valider les changement dans la bd
            return (Context.SaveChanges() > 0);
        }


        // ----- FIND -----
        public Monitor FindMonitor(int id)
        {
            return Context.Monitors.Find(id);
        }
        public List<Monitor> FindMonitor(string name)
        {
            var list = Context.Monitors.Where(p => p.NameMonitors.StartsWith(name) || p.FirstnameMonitors.StartsWith(name));
            return list.ToList();
        }
        public List<Monitor> FindMonitorName(string name)
        {
            var list = Context.Monitors.Where(p => p.NameMonitors.StartsWith(name));
            return list.ToList();
        }
        public List<Monitor> FindMonitorFirstname(string name)
        {
            var list = Context.Monitors.Where(p => p.FirstnameMonitors.StartsWith(name));
            return list.ToList();
        }
        public Monitor FindMonitorLogin(string login)
            => Context.Monitors.FirstOrDefault(monitor => monitor.LoginMonitor == login);
        

        public List<Monitor> AllMonitor()
        {
            var list = Context.Monitors.AsQueryable();
            return list.ToList();
        }
    }
}
