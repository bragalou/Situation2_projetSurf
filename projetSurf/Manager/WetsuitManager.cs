using Microsoft.EntityFrameworkCore;
using projetSurf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetSurf.Manager
{
    class WetsuitManager : Manager
    {
        // ----- ADD -----
        public Wetsuit AddWetsuit(Wetsuit wetsuit)
        {
            //ajouter le produit à l'orm ef
            Context.Wetsuits.Add(wetsuit);
            //valider les changements dnas la bd
            if (Context.SaveChanges() > 0)
                return wetsuit;
            return null;
        }

        // ----- DELETE -----
        public bool DeleteWetsuit(Wetsuit wetsuit)
        {
            if (wetsuit != null)
            {
                Context.Wetsuits.Remove(wetsuit);
                return (Context.SaveChanges() > 0);
            }
            return false;
        }
        public bool DeleteWetsuit(int id)
        {
            Wetsuit wetsuit = FindWetsuit(id);
            if (wetsuit == null)
                return false;
            return DeleteWetsuit(wetsuit);
        }

        // ----- EDIT -----
        public bool EditWetsuit(Wetsuit wetsuit)
        {
            //mettre le status de l'entité à modifier dans l'orm
            Context.Entry(wetsuit).State = EntityState.Modified;
            //valider les changement dans la bd
            return (Context.SaveChanges() > 0);
        }


        // ----- FIND -----
        public Wetsuit FindWetsuit(int id)
        {
            return Context.Wetsuits.Find(id);
        }
        public List<Wetsuit> FindWetsuitGender(string gender)
        {
            var list = Context.Wetsuits.Where(p => p.GenderWetsuits.StartsWith(gender));
            return list.ToList();
        }
        public List<Wetsuit> FindWetsuitType(string type)
        {
            var list = Context.Wetsuits.Where(p => p.TypeWetsuits.StartsWith(type));
            return list.ToList();
        }
        public List<Wetsuit> FindWetsuitZipper(string zipper)
        {
            var list = Context.Wetsuits.Where(p => p.ZipperWetsuits.StartsWith(zipper));
            return list.ToList();
        }
        public List<Wetsuit> FindWetsuitThickness(string thickness)
        {
            var list = Context.Wetsuits.Where(p => p.ThicknessWetsuits.StartsWith(thickness));
            return list.ToList();
        }
        public List<Wetsuit> FindWetsuitLengthSleeves(string lengthSleeves)
        {
            var list = Context.Wetsuits.Where(p => p.LengthSleevesWetsuits.StartsWith(lengthSleeves));
            return list.ToList();
        }
        public List<Wetsuit> FindWetsuitHood(string hood)
        {
            var list = Context.Wetsuits.Where(p => p.HoodWetsuits.StartsWith(hood));
            return list.ToList();
        }
        public int NmbWetsuit()
        {
            int nmb = Context.Wetsuits.Count();
            return nmb;
        }
        public int NmbReplaceWetsuit()
        {
            var list = Context.Wetsuits.AsQueryable();
            list = list.Where(f => f.StateWetsuits.Equals("inutilisable") || f.StateWetsuits.Equals("decrader"));
            int nmb = list.Count();
            return nmb;
        }
    }
}
