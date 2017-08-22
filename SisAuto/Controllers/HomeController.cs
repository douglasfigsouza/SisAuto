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
                Session["User"] = UsersRepository.autenticaUser(user);
                if(Session["User"]!=null)
                {
                    return RedirectToAction("addClientes", "Clientes");
                }
                else return RedirectToAction("/");
            }
            else return RedirectToAction("/");
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