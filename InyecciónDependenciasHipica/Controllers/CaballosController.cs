using InyecciónDependenciasHipica.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InyecciónDependenciasHipica.Controllers
{
    public class CaballosController : Controller
    {
        RepositoryCaballo repo;

        public CaballosController()
        {
            this.repo = new RepositoryCaballo();
        }

        // GET: Caballos
        public ActionResult Index()
        {
            return View(this.repo.GetCaballos());
        }
    }
}