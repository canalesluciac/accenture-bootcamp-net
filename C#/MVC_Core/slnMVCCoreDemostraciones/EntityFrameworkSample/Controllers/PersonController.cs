using EntityFrameworkExample.Data;
using EntityFrameworkSample.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace EntityFrameworkExample.Controllers
{
    public class PersonController : Controller
    {
        //inyección de dependencia
        private readonly PersonContext _context;

        public PersonController(PersonContext context)
        {
            _context = context;
        }

        // GET: /Person o /Person/Index
        public IActionResult Index()
        {
            return View(_context.People.ToList()); // a view se envía lista de personas
        }

        [HttpGet("/Person/ListaPorCiudad/{city}")] // Ruta personalizada HTTP
        //GET: /Person/ListaPorCiudad/{ciudad}
        public IActionResult ListaPorCiudad(string city)
        {
            List<Person> lista = (from p in _context.People
                                  where p.City == city
                                  select p).ToList();
            return View("Index", lista);            // RETORNO LISTA DE P. A VISTA INDEX
        }

        // GET: /Person/Edit/1
        public IActionResult Edit(int id)
        {
            var person = _context.People.SingleOrDefault(m => m.PersonId == id);
            person.FirstName = "Brandon";
            _context.Update(person);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        // GET: /Person/Create
        public IActionResult Create()
        {
            Person person = new Person();
            return View("Create", person);
        }

        [HttpPost]
        public IActionResult Create(Person person)
        {
            _context.Add(person);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        //GET: Person/Delete/1
        public IActionResult Delete(int id)
        {
            var person = _context.People.SingleOrDefault(m => m.PersonId == id);
            if(person != null)
            {
                _context.People.Remove(person);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
