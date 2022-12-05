using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCPubs.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace MVCPubs.Controllers
{
    public class StoreController : Controller
    {
        private readonly PubsContext _context;

        public StoreController(PubsContext context)
        {
            _context = context;
        }

        // GET: /Store        --> == LISTA DATOS DE STORE
        public IActionResult Index()
        {
            return View(_context.Stores.ToList());
        }

        // GET: /Store/Create        --> == ALTA
        public IActionResult Create()
        {
            Store store = new Store();
            return View("Create", store);
        }

        // POST: /Store/Create
        [HttpPost]
        public IActionResult Create(Store store)
        {
            if (ModelState.IsValid)
            {
                _context.Stores.Add(store);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View("Create", store);

            }
        }

        // GET: /Store/Edit/1        --> == MODIFICACION
        public IActionResult Edit(string id)
        {
           Store store = _context.Stores.Find(id);
            if (store == null)
            {
                NotFound();
            }
            return View("Edit", store);
        }

        //POST : /Store/Edit/{id}
        [HttpPost]
        public IActionResult Edit(Store store)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(store).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Edit", store);
        }

        //GET: /Store/Delete/1        --> == BAJA
        public IActionResult Delete(string id)
        {
            var store = _context.Stores.SingleOrDefault(m => m.StorId == id);
            if (store != null)
            {
                _context.Stores.Remove(store);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }

        //GET /Store/TraerUna/{id}
        public IActionResult TraerUna(string id)
        {
            Store store = _context.Stores.Find(id);
            if (store == null)
            {
                return NotFound();
            }
            return View("TraerUna", store);
        }

        [HttpGet("/Store/ListaPorCiudad/{City}")]
        //GET: /Store/ListaPorCiudad/{City}
        public IActionResult ListaPorCiudad(string City)
        {
            List<Store> lista = (from s in _context.Stores
                                    where s.City == City
                                    select s).ToList();
            return View("Index", lista);
        }

        [HttpGet("/Store/ListaPorEstado/{State}")]
        //GET: /Store/ListaPorEstado/{State}
        public IActionResult ListaPorEstado(string State)
        {
            List<Store> lista = (from s in _context.Stores
                                 where s.State == State
                                 select s).ToList();
            return View("Index", lista);
        }
    }
}
