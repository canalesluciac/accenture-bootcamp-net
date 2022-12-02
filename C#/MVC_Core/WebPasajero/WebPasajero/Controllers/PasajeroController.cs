using WebPasajero.Data;
using WebPasajero.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System;

namespace WebPasajero.Controllers
{
    public class PasajeroController: Controller
    {
        private readonly PasajeroContext _context;

        public PasajeroController(PasajeroContext context)
        {
            _context = context;
        }

        // GET: /Pasajero o /Pasajero/Index
        public IActionResult Index()
        {
            return View(_context.Pasajeros.ToList()); // a view se envía lista de personas
        }

        // GET: /Pasajero/Create
        public IActionResult Create()
        {
            Pasajero pasajero = new Pasajero();
            return View("Create", pasajero);
        }

        [HttpPost]
        public IActionResult Create(Pasajero pasajero)
        {
            _context.Add(pasajero);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("/Pasajero/ListaPorFechaNacimiento/{FechaNacimiento}")] // Ruta personalizada HTTP
        //GET: /Pasajero/ListaPorFechaNacimiento/{FechaNacimiento}
        public IActionResult ListaPorFechaNacimiento(DateTime fecha)
        {
            List<Pasajero> lista = (from p in _context.Pasajeros
                                  where p.FechaNacimiento == fecha
                                  select p).ToList();
            return View("Index", lista);            // RETORNO LISTA DE P. A VISTA INDEX
        }

        [HttpGet("/Pasajero/ListaPorCiudad/{Ciudad}")] 
        //GET: /Pasajero/ListaPorCiudad/{ciudad}
        public IActionResult ListaPorCiudad(string ciudad)
        {
            List<Pasajero> lista = (from p in _context.Pasajeros
                                  where p.Ciudad == ciudad
                                  select p).ToList();
            return View("Index", lista);            
        }
    }
}
