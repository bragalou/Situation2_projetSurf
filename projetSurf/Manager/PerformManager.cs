using Microsoft.EntityFrameworkCore;
using projetSurf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetSurf.Manager
{
    class PerformManager : Manager
    {
        // ----- ADD -----
        //ajouter le produit à l'orm ef
        public Perform AddPerform(Perform perform)
        {
            Context.Performs.Add(perform);
            //valider les changements dnas la bd
            if (Context.SaveChanges() > 0)
                return perform;
            return null;
        }

        // ----- Remove -----
        public bool DeletePerform(int idMonitor, int idLesson)
        {
            var relation = Context.Performs.Where(f => f.IdMonitors == idMonitor && f.IdLessons == idLesson).FirstOrDefault();
            if (relation != null)
            {
                Context.Performs.Remove(relation);
                return (Context.SaveChanges() > 0);
            }
            return false;
        }

        public bool DeleteAllPerformByLesson(int idLesson)
        {
            var relations = Context.Performs.Where(f => f.IdLessons == idLesson);
            if (relations != null)
            {
                foreach (Perform relation in relations)
                {
                    Context.Performs.Remove(relation);
                }
                return (Context.SaveChanges() > 0);
            }
            return false;
        }
        public bool DeleteAllPerformByMonitor(int idMonitor)
        {
            var relations = Context.Performs.Where(f => f.IdMonitors == idMonitor);
            if (relations != null)
            {
                foreach (Perform relation in relations)
                {
                    Context.Performs.Remove(relation);
                }
                return (Context.SaveChanges() > 0);
            }
            return false;
        }

        // ----- FIND -----
        public List<Perform> FindMonitorByLesson(int id)
        {
            var list = Context.Performs.Include(f => f.IdMonitorsNavigation).AsQueryable();
            list = list.Where(f => f.IdLessons.Equals(id));
            //list = list.Select(f => f.IdMonitorsNavigation.FirstnameMonitors);
            return list.ToList();
        }
        public Perform FindRelation(int idMonitor, int idLesson)
        {
            var relation = Context.Performs.Where(f => f.IdMonitors == idMonitor && f.IdLessons == idLesson).FirstOrDefault();
            if (relation != null)
                return relation;
            return null;
        }
    }
}
