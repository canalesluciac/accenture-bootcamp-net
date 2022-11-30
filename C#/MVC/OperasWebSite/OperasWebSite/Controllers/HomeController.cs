using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OperasWebSite.Filters;

namespace OperasWebSite.Controllers
{
    [MyActionFilter]
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Fecha = DateTime.Now.ToString(); // Imprime la fecha
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Contenido en view About";
            return View();
        }
    }
}