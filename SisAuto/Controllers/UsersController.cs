﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SisAuto.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult registerUsers()
        {
            return View();
        }
    }
}