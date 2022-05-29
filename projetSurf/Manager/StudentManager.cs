using Microsoft.EntityFrameworkCore;
using projetSurf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetSurf.Manager
{
    class StudentManager : Manager
    {
        // ----- ADD -----
        public Student AddStudent(Student student)
        {
            //ajouter le produit à l'orm ef
            Context.Students.Add(student);
            //valider les changements dnas la bd
            if (Context.SaveChanges() > 0)
                return student;
            return null;
        }

        // ----- DELETE -----
        public bool DeleteStudent(Student student)
        {
            if (student != null)
            {
                Context.Students.Remove(student);
                return (Context.SaveChanges() > 0);
            }
            return false;
        }
        public bool DeleteStudent(int id)
        {
            Student student = FindStudent(id);
            if (student == null)
                return false;
            return DeleteStudent(student);
        }

        // ----- EDIT -----
        //public bool EditStudent(Student student)
        //{
            //mettre le status de l'entité à modifier dans l'orm
            //Context.Entry(student).State = EntityState.Modified;
            //valider les changement dans la bd
        //    return (Context.SaveChanges() > 0);
        //}
        public Student EditStudent(Student student)
        {
            //mettre le status de l'entité à modifier dans l'orm
            Context.Entry(student).State = EntityState.Modified;
            //valider les changement dans la bd
            if (Context.SaveChanges() > 0)
                return student;
            return null;
        }


        // ----- FIND -----
        public Student FindStudent(int id)
        {
            return Context.Students.Find(id);
        }
        public List<Student> FindStudent(string name)
        {
            var list = Context.Students.Where(p => p.FirstnameClients.StartsWith(name));
            return list.ToList();
        }
        public int NmbStudent()
        {
            int nmb = Context.Students.Count();
            return nmb;
        }

        public List<Student> AllStudents()
        {
            var list = Context.Students.AsQueryable();
            return list.ToList();
        }
    }
}
