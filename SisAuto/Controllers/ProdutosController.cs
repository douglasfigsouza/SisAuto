﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SisAuto.Controllers
{
    public class ProdutosController : Controller
    {
        // GET: Produtos
        public ActionResult AddProduto()
        {
            return View();
        }
    }
}