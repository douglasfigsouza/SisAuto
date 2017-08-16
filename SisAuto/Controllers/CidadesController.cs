using SisAuto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SisAuto.Controllers
{
    public class CidadesController : Controller
    {
        private readonly CidadeEstadoRepository cidadeEstadoRep;
        public CidadesController()
        {
            this.cidadeEstadoRep = new CidadeEstadoRepository();
        }
        public JsonResult getAllCitiesIdStates(int id)
        {
            return Json(cidadeEstadoRep.getCitiesIdState(id), JsonRequestBehavior.AllowGet);
        }
    }
}