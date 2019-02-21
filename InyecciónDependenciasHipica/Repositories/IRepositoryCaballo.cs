using InyecciónDependenciasHipica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyecciónDependenciasHipica.Repositories
{
     public interface IRepositoryCaballo
    {
        List<Caballo> GetCaballos();
    }
}
