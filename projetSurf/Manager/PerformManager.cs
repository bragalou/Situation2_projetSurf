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

        // ----- DELETE -----
        public bool DeletePerfom(Perform perform)
        {
            if (perform != null)
            {
                //Context.Entry(perform).State = EntityState.Detached;
                Context.Performs.Remove(perform);
               // return (Context.SaveChanges() > 0);
            }
            return false;
        }




        //public bool DeletePerformByMonitor(int id)
        //{
        //    Perform performa = Context.Performs.Find(id);
        //    Context.Performs.Remove(performa);
        //    return (Context.SaveChanges() > 0);


        //    var list = (
        //        from perform in Context.Set<Perform>()
        //        .Where(f => f.IdMonitors == id)
        //        .
        //        )


            
        //}

    //    (from product in context.Set<Product>()
    //         from order in context.Set<Orderdetail>()
    //        .Where(f => f.ProductId == product.ProductId)
    //        .DefaultIfEmpty()
    //         select new
    //         {
    //             product,
    //             order
    //})
    //                     .Where(order => order.order == null).ToList();



    // ----- FIND -----
    public List<Perform> FindMonitorByLesson(int id)
        {
            var list = Context.Performs.Include(f => f.IdMonitorsNavigation).AsQueryable();
            list = list.Where(f => f.IdLessons.Equals(id));
            //list = list.Select(f => f.IdMonitorsNavigation.FirstnameMonitors);
            return list.ToList();
        }

        public List<Perform> FindMonitor(int id)
        {
            var list = Context.Performs.Include(f => f.IdMonitorsNavigation).AsQueryable();
            list = list.Where(f => f.IdMonitors.Equals(id));
            return list.ToList();
        }
    }
}
