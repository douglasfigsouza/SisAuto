using SisAuto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SisAuto.Models;

namespace SisAuto.Controllers
{
    public class HomeController : Controller
    {
        private readonly UsersRepository usersRep;
        
        public HomeController()
        {
            this.usersRep = new UsersRepository();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ActionName("Login")]
        public ActionResult Logar(USUARIOS user)
        {
           
            user.LOGINUSU = user.LOGINUSU;
            user.SENHAUSU = user.SENHAUSU;
            ModelState.Clear();
            if (ModelState.IsValid)
            {
                if (usersRep.autenticaUser(user))
                {
                    Session["User"] = user;
                    var teste= (USUARIOS)Session["User"];
                    ViewBag.UserLogado = teste.LOGINUSU;
                    return RedirectToAction("addClientes", "Clientes");
                }
                else return View();
            }
            else return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}