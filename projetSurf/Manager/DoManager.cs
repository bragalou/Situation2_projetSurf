using Microsoft.EntityFrameworkCore;
using projetSurf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetSurf.Manager
{
    class DoManager : Manager
    {
        // ----- ADD -----
        public Do AddDo(Do inscrit)
        {
            Context.Dos.Add(inscrit);
            if (Context.SaveChanges() > 0)
                return inscrit;
            return null;
        }

        // ----- REMOVE -----
        public bool DeleteDo(int idClient, int idLesson)
        {
            var relation = Context.Dos.Where(f => f.IdClients == idClient && f.IdLessons == idLesson).FirstOrDefault();
            if (relation != null)
            {
                Context.Dos.Remove(relation);
                return (Context.SaveChanges() > 0);
            }
            return false;
        }


        // ----- FIND -----
        public List<Do> FindLessonsByStudent(int id)
        {
            var list = Context.Dos.Include(f => f.IdLessonsNavigation).AsQueryable();
            list = list.Where(f => f.IdClients.Equals(id));
            return list.ToList();
        }
        public List<Do> FindStudentByLesson(int id)
        {
            var list = Context.Dos.Include(f => f.IdClientsNavigation).AsQueryable();
            list = list.Where(f => f.IdLessons.Equals(id));
            return list.ToList();
        }

        public int NmbStudentByLesson(int id)
        {
            var list = Context.Dos.Include(f => f.IdClientsNavigation).AsQueryable();
            list = list.Where(f => f.IdLessons.Equals(id));
            return list.ToList().Count();
        }

        public Do FindRelation(int idClient, int idLesson)
        {
            var relation = Context.Dos.Where(f => f.IdClients == idClient && f.IdLessons == idLesson).FirstOrDefault();
            if (relation != null)
                return relation;
            return null;
        }
    }
}
