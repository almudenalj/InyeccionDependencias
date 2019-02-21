using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InyecciónDependenciasHipica.Models;

namespace InyecciónDependenciasHipica.Repositories
{
    public class RepositoryCaballo : IRepositoryCaballo

    {
        CaballosContext context;

        public RepositoryCaballo()
        {
            this.context = new CaballosContext();
        }

        public List<Caballo> GetCaballos()
        {
            var consulta = from datos in context.Caballos
                           select datos;
            return consulta.ToList();
        }
    }
}