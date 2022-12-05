using Microsoft.AspNetCore.Mvc;
using SistemaWebEmpleado.Data;
using SistemaWebEmpleado.Models;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Globalization;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace SistemaWebEmpleado.Controllers
{
    public class EmpleadoController : Controller
    {
        private readonly DBEmpleadoContext _context;
        public EmpleadoController(DBEmpleadoContext context)
        {
            _context = context;
        }

        // GET: /Empleado
        public IActionResult Index()
        {
            return View(_context.Empleados.ToList()); 
        }

        // GET: /Empleado/Create
        public IActionResult Create()
        {
            Empleado empleado = new Empleado();
            return View("Create", empleado);
        }

        [HttpPost]
        public IActionResult Create(Empleado empleado)
        {
            if (ModelState.IsValid)
            {
               _context.Empleados.Add(empleado);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("Create", empleado);
            
            }
            
        }

        [HttpGet("/Empleado/ListaPorTitulo/{Titulo}")]
        //GET: /Empleado/ListaPorTitulo/{Titulo}
        public IActionResult ListaPorTitulo(string titulo)
        {
            List<Empleado> lista = (from e in _context.Empleados
                                    where e.Titulo == titulo
                                    select e).ToList();
            return View("Index", lista);
        }

        // GET: /Empleado/Edit/1
        public IActionResult Edit(int id)
        {
            Empleado empleado = _context.Empleados.Find(id);
            if (empleado == null)
            {
                NotFound();
            }
            return View("Edit", empleado);
        }

        //POST : /Empleado/Edit/{id}
        [HttpPost]
        public ActionResult Edit(int id)
        {
            Empleado empleado = _context.Empleados.Find(id);

            _context.Entry(empleado).State = EntityState.Modified;
            _context.SaveChanges();
            return View("Edit", empleado);
        }

        //GET: /Empleado/Delete/1
        public IActionResult Delete(int id)
        {
            var empleado = _context.Empleados.SingleOrDefault(m => m.Id == id);
            if (empleado != null)
            {
                _context.Empleados.Remove(empleado);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }

        //GET /Empleado/TraerUno/{id}
        public IActionResult TraerUno (int id)
        {
            Empleado empleado = _context.Empleados.Find(id);
            if (empleado == null)
            {
                return NotFound();
            }
            return View("TraerUno", empleado);
        }
    }
}
