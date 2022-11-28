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
            return View();
        }

        // GET: Aula/Create
        public ActionResult Create()    // Devuelve 1 vista "Register"
        {
            Aula aula = new Aula();
            return View("Register", aula);
        }

        // POST: Aula/Create
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
                return View("Crear", aula);
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
            return View("Modificar", aula);

        }

        // POST: /Aula/Edit/2
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

        // GET: /Aula/ListarPorEstado
        /* Busca en la base de datos. Retorna la vista “Index” y la lista de aulas. */
        public ActionResult ListarPorEstado(string estado)
        {
            // TODO: Listar o por "Estado" (propiedad) o por EntityState
            return View("Index");
        }

        // GET: /Aula/TraerPorNumero/1
        public ActionResult TraerPorNumero( int numero) // Recibe parámetro número
        {
            Aula aula = context.Aulas.Find(numero); // Busca en DB por numero
            return View("Details", aula);           // Retorna vista Details del aula
        }
    }
}