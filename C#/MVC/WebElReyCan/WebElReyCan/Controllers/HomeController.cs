using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebElReyCan.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.fecha = DateTime.Now.ToString();
            return View();
        }

        //TODO: sección para mostrar texto relacionado al cuidado del pelaje de algun perro de raza
        //TODO: si no se usa la sección --> link a Wikipedia: Peluquero canino
    }
}