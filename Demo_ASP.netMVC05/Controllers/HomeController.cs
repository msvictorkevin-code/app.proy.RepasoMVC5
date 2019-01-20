﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo_ASP.netMVC05.Controllers
{
    public class HomeController : Controller
    {
        public FileResult Index()
        {
            var ruta = Server.MapPath("Archivo.pdf");
            return File(ruta, "application/pdf", "Ejemplo 6.pdf");
            //return View();
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