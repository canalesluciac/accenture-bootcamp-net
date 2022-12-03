using Microsoft.AspNetCore.Mvc;
using MVCPubs.Data;
using MVCPubs.Models;
using System.Collections.Generic;
using System.Linq;

namespace MVCPubs.Controllers
{
    public class StoreController : Controller
    {
        private readonly PubsContext _context;

        public StoreController(PubsContext context)
        {
            _context = context;
        }

        // GET: /Store 
        public IActionResult Index()
        {
            return View(_context.Stores.ToList());
        }

        // GET: /Store/Create
        public IActionResult Create()
        {
            Store store = new Store();
            return View("Create", store);
        }

        // POST: /Store/Create
        [HttpPost]
        public IActionResult Create(Store store)
        {
            _context.Add(store);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        //GET: /Store/Delete/1
        public IActionResult Delete(int id)
        {
            var person = _context.Stores.SingleOrDefault(m => m.PersonId == id);
            if (person != null)
            {
                _context.Stores.Remove(person);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
