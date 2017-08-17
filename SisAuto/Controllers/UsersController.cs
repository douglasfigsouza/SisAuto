﻿using SisAuto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SisAuto.Controllers
{
    public class UsersController : Controller
    {
        private readonly UsuersRepository usersRep;
        public UsersController()
        {
            this.usersRep = new UsuersRepository();
        }
        // GET: Users
        public ActionResult registerUsers()
        {
            return View();
        }
        [HttpPost]
        public ActionResult registerUsers(USUARIOS user)
        {
            if (ModelState.IsValid)
            {
                usersRep.AddUsers(user);
            }
            return View();
        }
    }
}