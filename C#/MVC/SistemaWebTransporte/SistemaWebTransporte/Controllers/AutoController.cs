using SistemaWebTransporte.Data;
using SistemaWebTransporte.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;

namespace SistemaWebTransporte.Controllers
{
    public class AutoController : Controller
    {
        private SistemaWebTransporteDBContext context = new SistemaWebTransporteDBContext();
        // GET: Auto
        [HttpGet]
        public ActionResult Index()
        {
            List<Auto> lista = context.Autos.ToList();
            return View("Index", lista);
        }
        [HttpGet]
        public ActionResult Create()
        {
            Auto newAuto = new Auto();
            return View("Create", newAuto);
        }
        [HttpPost]
        public ActionResult Create(Auto auto)
        {

            if (ModelState.IsValid)
            {
                context.Autos.Add(auto);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("Create", auto);
            }
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            Auto auto = context.Autos.Find(id);

            if (auto == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(auto);
            }

        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Auto auto = context.Autos.Find(id);

            if (auto == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View("Delete", auto);
            }

        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Auto auto = context.Autos.Find(id);
            if (auto != null)
            {
                context.Autos.Remove(auto);
                context.SaveChanges();
            }

            return RedirectToAction("Index");

        }






    }
}