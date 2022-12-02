using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Data.Entity;
using WebElReyCan.Data;
using WebElReyCan.Models;

namespace WebElReyCan.Controllers
{
    public class TurnoController : Controller
    {
        private ReyCanDBContext context = new ReyCanDBContext();

        // GET: Turno
        public ActionResult Index()
        {
            ViewBag.Fecha = DateTime.Now.ToString();

            List<Turno> lista = context.Turnos.ToList();
            return View("Index", lista);
        }

        // GET: Turno/Create
        public ActionResult Create()
        {
            Turno turno = new Turno();
            return View("Create", turno);
        }
        // POST: Turno/Create/{turno}
        [HttpPost]
        public ActionResult Create(Turno turno)
        {
            if (ModelState.IsValid)
            {
                context.Turnos.Add(turno);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("Create", turno);
            }
        }

        //GET: Turno/ListarPorDia/fecha
        public ActionResult ListarPorDia(string fecha)
        {
            dynamic buscaFecha = (from f in context.Turnos
                                  where f.Fecha == fecha
                                  select f).ToList();
            return View("ListarPorDia", buscaFecha);
        }

        //GET: Turno/ListarPorFecha
        public ActionResult ListarPorFecha()
        {
            ViewBag.Fecha = DateTime.Now.Date.ToString();
            string fechaAct = DateTime.Now.Date.ToString(); // TODO: Check
            dynamic buscaFecha = (from f in context.Turnos
                                  where f.Fecha == fechaAct
                                  select f).ToList();
            return View("ListarPorDia", buscaFecha);
        }

        // GET: /Turno/Delete/id
        public ActionResult Delete(int id)
        {
            Turno turno = context.Turnos.Find(id);

            if (turno == null)
            {
                return HttpNotFound();
            }
            return View("Delete", turno);
        }

        //POST /Turno/Delete/id
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Turno turno = context.Turnos.Find(id);
            if (turno != null)
            {
                context.Turnos.Remove(turno);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        //GET:Turno/Edit/id
        public ActionResult Edit(int id)
        {
            Turno turno = context.Turnos.Find(id);
            if (turno == null)
            {
                HttpNotFound();
            }
            return View("Edit", turno);
        }

        //POST : Turno/Edit/id
        [HttpPost]
        public ActionResult EditConfirmed(int id)
        {
            Turno turno = context.Turnos.Find(id);

            context.Entry(turno).State = EntityState.Modified;
            context.SaveChanges();
            return View("Modificar", turno);
        }
    }
}