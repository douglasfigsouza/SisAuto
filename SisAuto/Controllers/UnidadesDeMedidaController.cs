using SisAuto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SisAuto.Controllers
{
    public class UnidadesDeMedidaController : Controller
    {
        private readonly UnidadesDeMedidaRepository unidMedidaRep;

        public UnidadesDeMedidaController()
        {
            this.unidMedidaRep = new UnidadesDeMedidaRepository();
        }
        // GET: UnidadesDeMedida
        public ActionResult AddUnidMedida()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddUnidMedida(UNIDMEDIDA unid)
        {
            if (ModelState.IsValid)
            {
                unidMedidaRep.AddUnidMedida(unid);
                return View();
            }
            return View();
        }

    }
}