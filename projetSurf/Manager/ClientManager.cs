using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projetSurf.Models;
using Microsoft.EntityFrameworkCore;

namespace projetSurf.Manager
{
    public class ClientManager : Manager
    {
        // ----- ADD -----
        public Client AddClient(Client client)
        {
            //ajouter le produit à l'orm ef
            Context.Clients.Add(client);
            //valider les changements dnas la bd
            if (Context.SaveChanges() > 0)
                return client;
            return null;
        }

        // ----- DELETE -----
        public bool DeleteClient(Client client)
        {
            if(client != null)
            {
                Context.Clients.Remove(client);
                return (Context.SaveChanges() > 0);
            }
            return false;
        }
        public bool DeleteClient(int id)
        {
            Client client = FindClient(id);
            if (client == null)
                return false;
            return DeleteClient(client);
        }

        // ----- EDIT -----
        public bool EditClient(Client client)
        {
            //mettre le status de l'entité à modifier dans l'orm
            Context.Entry(client).State = EntityState.Modified;
            //valider les changement dans la bd
            return (Context.SaveChanges() > 0);
        }


        // ----- FIND -----
        public Client FindClient(int id)
        {
            return Context.Clients.Find(id);
        }
        public List<Client> FindClient(string name)
        {
            var list = Context.Clients.Where(p => p.NameClients.StartsWith(name) || p.FirstnameClients.StartsWith(name));
            return list.ToList();
        }
        public List<Client> FindClientName(string name)
        {
            var list = Context.Clients.Where(p => p.NameClients.StartsWith(name));
            return list.ToList();
        }
        public List<Client> FindClientFirstname(string name)
        {
            var list = Context.Clients.Where(p => p.NameClients.StartsWith(name));
            return list.ToList();
        }

        public List<Client> AllClient()
        {
            var list = Context.Clients.AsQueryable();
            return list.ToList();
        }

        public int NmbClient()
        {
            int nmb = Context.Clients.Count();
            return nmb;
        }
    }
}
