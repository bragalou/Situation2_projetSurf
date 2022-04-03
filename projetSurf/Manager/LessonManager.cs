using Microsoft.EntityFrameworkCore;
using projetSurf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetSurf.Manager
{
    class LessonManager : Manager
    {
        // ----- ADD -----
        public Lesson AddLesson(Lesson lesson)
        {
            //ajouter le produit à l'orm ef
            Context.Lessons.Add(lesson);
            //valider les changements dnas la bd
            if (Context.SaveChanges() > 0)
                return lesson;
            return null;
        }

        // ----- DELETE -----
        public bool DeleteLesson(Lesson lesson)
        {
            if (lesson != null)
            {
                Context.Lessons.Remove(lesson);
                return (Context.SaveChanges() > 0);
            }
            return false;
        }
        public bool DeleteLesson(int id)
        {
            Lesson lesson = FindLesson(id);
            if (lesson == null)
                return false;
            return DeleteLesson(lesson);
        }

        // ----- EDIT -----
        public bool EditLesson(Lesson lesson)
        {
            //mettre le status de l'entité à modifier dans l'orm
            Context.Entry(lesson).State = EntityState.Modified;
            //valider les changement dans la bd
            return (Context.SaveChanges() > 0);
        }


        // ----- FIND -----
        public Lesson FindLesson(int id)
        {
            return Context.Lessons.Find(id);
        }
        public List<Lesson> FindLessonLevel(string level)
        {
            var list = Context.Lessons.Where(p => p.LevelLessons.StartsWith(level));
            return list.ToList();
        }
    }
}
