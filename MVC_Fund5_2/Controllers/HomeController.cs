﻿using MVC_Fund5_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Helpers;


namespace MVC_Fund5_2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(ProductDatabase.Products);
        }

    }
}