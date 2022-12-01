using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebEscuelaMVC.Data;
using WebEscuelaMVC.Models;

namespace WebEscuelaMVC.Controllers
{
    public class AulaController : Controller
    {
        private AulaDBContext context = new AulaDBContext();

        // GET: Aula
        public ActionResult Index()         // Devuelve vista + todas las aulas
        {
            List<Aula> list = context.Aulas.ToList();
            return View("Index", list);
        }

        // GET: Aula/Create
        public ActionResult Create()    // Devuelve 1 vista "Register"
        {
            Aula aula = new Aula();
            return View("Register", aula);
        }

        // POST: Aula/Create
        [HttpPost]
        public ActionResult Create(Aula aula)   // Guarda la nueva aula en la DB
        {
            if (ModelState.IsValid)
            {
                context.Aulas.Add(aula);
                context.SaveChanges();              // Guarda aula en DB
                return RedirectToAction("Index");
            }
            else
            {
                return View("Register", aula);
            }
        }

        // GET: Aula/Details
        public ActionResult Details (int id)        // Devuelve vista "Detalle" + objeto aula
        {
            Aula aula = context.Aulas.Find(id);
            if (aula == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View("Detalle", aula);
            }
        }

        // GET: Aula/Edit/2
        public ActionResult Edit(int id)        // Devuelve Vista Modificar
        {
            /*if (id == null)       // POR SI EL PARAMETRO ES (int? id)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }*/

            Aula aula = context.Aulas.Find(id);
            if (aula == null)
            {
                return HttpNotFound();
            }
            return View("Edit", aula);

        }

        // POST: /Aula/Edit/2
        [HttpPost]
        public ActionResult Edit(Aula aula)     
        {
            if (ModelState.IsValid) 
            {
                context.Entry(aula).State = EntityState.Modified;       
                context.SaveChanges();              // Guarda aula modificada en DB
                return RedirectToAction("Index");
            }
            return View("Modificar", aula);
        }

        //GET: /Aula/Delete/2
        public ActionResult Delete(int id)
        {
            Aula aula = context.Aulas.Find(id);
            if (aula == null)
            {
                return HttpNotFound();
            }
            return View("Delete", aula);
        }
        //POST: /Aula/Delete/2
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Aula aula = context.Aulas.Find(id);
            if (aula != null)
            {
                context.Aulas.Remove(aula);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        // GET: /Aula/ListarPorEstado
        /* Busca en la base de datos. Retorna la vista “Index” y la lista de aulas. */
        public ActionResult ListarPorEstado(string estado)
        {
            List<Aula> list = (from a in context.Aulas where estado == a.Estado select a).ToList();
            return View("Index", list);
        }

        // GET: /Aula/TraerPorNumero/1
        public ActionResult TraerPorNumero( int numero) 
        {
            dynamic buscaNum = (from a in context.Aulas where numero == a.Numero select a).ToList();
            return View("Details", buscaNum);           // Busca por numero de aula (se asume que podría haber más de uno por no ser lo mismo que el Id)
        }
    }
}