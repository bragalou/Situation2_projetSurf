using Microsoft.EntityFrameworkCore;
using projetSurf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetSurf.Manager
{
    class BoardManager : Manager
    {
        // ----- ADD -----
        public Board AddBoard(Board board)
        {
            //ajouter le produit à l'orm ef
            Context.Boards.Add(board);
            //valider les changements dnas la bd
            if (Context.SaveChanges() > 0)
                return board;
            return null;
        }

        // ----- DELETE -----
        public bool DeleteBoard(Board board)
        {
            if (board != null)
            {
                Context.Boards.Remove(board);
                return (Context.SaveChanges() > 0);
            }
            return false;
        }
        public bool DeleteBoard(int id)
        {
            Board board = FindBoard(id);
            if (board == null)
                return false;
            return DeleteBoard(board);
        }

        // ----- EDIT -----
        public bool EditBoard(Board board)
        {
            //mettre le status de l'entité à modifier dans l'orm
            Context.Entry(board).State = EntityState.Modified;
            //valider les changement dans la bd
            return (Context.SaveChanges() > 0);
        }


        // ----- FIND -----
        public Board FindBoard(int id)
        {
            return Context.Boards.Find(id);
        }
        public List<Board> FindBoard(string size)
        {
            var list = Context.Boards.Where(p => p.SizeBoards.StartsWith(size));
            return list.ToList();
        }
        public int NmbBoard()
        {
            int nmb = Context.Boards.Count();
            return nmb;
        }
        public int NmbReplaceBoard()
        {
            var list = Context.Boards.AsQueryable();
            list = list.Where(f => f.StateBoards.Equals("inutilisable") || f.StateBoards.Equals("decrader"));
            int nmb = list.Count();
            return nmb;
        }
    }
}
