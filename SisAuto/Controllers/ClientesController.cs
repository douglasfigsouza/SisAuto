using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SisAuto.Models;

namespace SisAuto.Controllers
{
    public class ClientesController : Controller
    {
        private CidadeEstadoRepository cidadeEstadoRep;
        public ClientesController()
        {
            this.cidadeEstadoRep = new CidadeEstadoRepository();
        }
        // GET: Clientes
        public ActionResult addClientes()
        {
            ViewBag.allStates = cidadeEstadoRep.getAllStates().ToList();
            return View();
        }
    }
}