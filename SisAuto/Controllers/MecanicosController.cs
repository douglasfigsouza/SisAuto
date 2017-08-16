using SisAuto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace SisAuto.Controllers
{
    public class MecanicosController : Controller
    {
        private CidadeEstadoRepository cidadeEstadoRep;
        public MecanicosController()
        {
            this.cidadeEstadoRep = new CidadeEstadoRepository();
        }
        [HttpGet]
        public JsonResult getAllCitiesIdStates(int id)
        {
            return Json(cidadeEstadoRep.getCitiesIdState(id), JsonRequestBehavior.AllowGet);
        }
        // GET: Mecanicos
        public ActionResult addMechanics()
        {
            ViewBag.allStates = cidadeEstadoRep.getAllStates();
            return View();
        }
    }
}