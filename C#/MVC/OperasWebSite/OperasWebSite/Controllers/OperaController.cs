using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OperasWebSite.Data;
using OperasWebSite.Models;

namespace OperasWebSite.Controllers
{
    public class OperaController : Controller
    {
        // CREAR - Instancia del context
        private OperaDBContext context = new OperaDBContext();

        // GET: Opera
        public ActionResult Index()
        {
            List<Opera> lista = context.Operas.ToList(); // context - DbSet - método ToList()
            return View("Index",lista);          // Devuelve vista de operas
        }

        // GET: Opera/Create   ( {controlador}/{metodo} )
        public ActionResult Create()
        {
            Opera opera = new Opera(); // 1. New instancia del modelo
            return View("Crear", opera);         //  2. Objeto creado se envía a vista --> Post
        }

        //POST: /Opera/Create
        [HttpPost]
        public ActionResult Create(Opera opera)
        {
            if (ModelState.IsValid)     // Propiedad del controlador que valida el modelo
            {
                context.Operas.Add(opera);      // Si modelo es válido --> agrega
                context.SaveChanges();          //   y lo guarda en la Db
                return RedirectToAction("Index");   // Luego muestra la vista de Index
            } else
            {
                return View("Crear",opera);         // Usuario recibe un ErrorMessage -->
                                            // podría llamarse a la vista return View("Crear", opera);
            }
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            Opera opera = context.Operas.Find(id); // busca la opera x su Id
            if (opera == null)
            {
                return HttpNotFound();  // Error not found (no existe)
            } else
            {
                return View(opera);     // Detalle de opera (existe)
            }
        }

        // GET: /Opera/Delete/id        --> Retorna formulario del Delete
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Opera opera = context.Operas.Find(id);
            if (opera == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View("Delete", opera);
            }
        }

        // POST: /Opera/Delete
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Opera opera = context.Operas.Find(id);
            if (opera != null)
            {
                context.Operas.Remove(opera);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}