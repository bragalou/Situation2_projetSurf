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

        public bool EditDo(Do inscrit)
        {
            Context.Entry(inscrit).State = EntityState.Modified;
            return (Context.SaveChanges() > 0);

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
    }
}
