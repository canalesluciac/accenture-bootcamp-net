using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;
using WebElReyCan.Data;
using WebElReyCan.Models;

namespace WebElReyCan.Controllers
{
    
    public class TurnoController : Controller
    {
        private ReyCanDBContext context = new ReyCanDBContext();

        // lista todos los turnos
        // GET: Turno/Index
        public ActionResult Index()
        {
            ViewBag.Fecha = DateTime.Now.ToString();

            List<Turno> lista = context.Turnos.ToList();
            return View("Index", lista);
        }

        // GET: /Turno/Delete/id
        [HttpGet]
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


        //edita turno
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

        //GET: Turno/ListarPorDia/fecha
        public ActionResult ListarPorDia (string fecha)
        {
            dynamic buscaFecha = (from f in context.Turnos
                                  where f.Fecha == fecha
                                  select f).ToList();
            return View("ListarPorDia", buscaFecha);
        }

        
    }
}