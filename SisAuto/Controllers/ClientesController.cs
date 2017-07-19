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
        [HttpGet]
        public JsonResult getAllCitiesIdStates(int id)
        {
           return Json(cidadeEstadoRep.getCitiesIdState(id), JsonRequestBehavior.AllowGet);
        }
        // GET: Clientes
        public ActionResult addClientes()
        {
            ViewBag.allStates = cidadeEstadoRep.getAllStates().ToList();
            return View();
        }
        [HttpPost]
        public ActionResult addClientes(CLIENTES cliente)
        {
            cliente.CIDADEID = cliente.CIDADEID;
            
            return View();
        }
    }
}