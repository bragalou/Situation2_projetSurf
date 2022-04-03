using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projetSurf.Models;

namespace projetSurf.Manager
{
    public abstract class Manager
    {
        public readonly projetSurfContext Context;

        public Manager()        
        {
            Context = new projetSurfContext();
        }
    }
}