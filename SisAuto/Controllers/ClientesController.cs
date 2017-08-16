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
        private ClientesRepository clientesRep;
        private bool flag;
        public ClientesController()
        {
            this.cidadeEstadoRep = new CidadeEstadoRepository();
            this.clientesRep = new ClientesRepository();
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
            if (ModelState.IsValid)
            {
                cliente.ATIVO = true;
                flag = clientesRep.addClient(cliente);
            }          
            return View();
        }
    }
}