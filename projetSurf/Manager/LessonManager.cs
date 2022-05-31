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
        public List<Lesson> FindLessonByLevel(string level)
        {
            var list = Context.Lessons.Where(p => p.LevelLessons.Contains(level));
            return list.ToList();
        }
        public List<Lesson> FindAllLessonByName(string name)
        {
            var list = Context.Lessons.Where(p => p.NameLessons.Contains(name));
            return list.ToList();
        }
        public List<Lesson> FindAllExactLessonByName(string name)
        {
            var list = Context.Lessons.Where(p => p.NameLessons.Equals(name));
            return list.ToList();
        }
        public List<Lesson> FindUniqueExactLessonByName(string name)
        {
            var list = Context.Lessons.Where(p => p.NameLessons.Equals(name)).Take(1);
            return list.ToList();
        }


        public List<Lesson> AllLessons()
        {
            var list = Context.Lessons.AsQueryable();
            list = list.OrderBy(f => f.DayLessons).OrderBy(f => f.StartHourLessons);
            return list.ToList();
        }

        public List<Lesson> AllLessonsInProgress()
        {
            DateTime today = DateTime.Now;
            var list = Context.Lessons.AsQueryable();
            list = list.Where(f => f.DateStartLessons.AddDays(f.NumberLessons*7) >= today);
            list = list.OrderBy(f => f.DayLessons).ThenBy(f => f.StartHourLessons);
            return list.ToList();
        }

        public List<Lesson> AllLessonsInProgressTOP3()
        {
            //DateTime today = DateTime.Now;
            //var list = Context.Lessons.AsQueryable();
            //list = list.Where(f => f.DateStartLessons.AddDays(f.NumberLessons * 7) >= today);
            //list = list.Min(f => f.NmbMaxLessons);
            //list = list.OrderBy(f => f.DayLessons).ThenBy(f => f.StartHourLessons);
            //return list.ToList();

            //var list = Context.Performs
            //    .FromSqlRaw("")
            //    .ToList();

            //return list;

            DateTime today = DateTime.Now;
            var list = Context.Lessons.AsQueryable();
            list = list.Where(f => f.DateStartLessons.AddDays(f.NumberLessons * 7) >= today);
            list = list.OrderBy(f => f.placeDispo).Take(3);
            return list.ToList();

        }
    }
}
