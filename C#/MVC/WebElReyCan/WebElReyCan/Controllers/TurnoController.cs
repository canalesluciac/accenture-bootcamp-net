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

        // GET: Turno ?????????????????????????????
        public ActionResult Index()
        {
            ViewBag.Fecha = DateTime.Now.ToString();

            List<Turno> lista = context.Turnos.ToList();
            return View("Index", lista);
        }



        // GET: /turno/Delete/id
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

        //POST /turno/delete
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


        //edita aula
        //GET:Aula/Edit/id
        public ActionResult Edit(int id)
        {

            Turno turno = context.Turnos.Find(id);
            if (turno == null)
            {
                HttpNotFound();

            }
            return View("Edit", turno);

        }
        //POST : Aula/Edit/id
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