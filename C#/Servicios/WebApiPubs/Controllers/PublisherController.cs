using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using WebApiPubs.Models; // !!
using System.Collections.Generic; // !!
using System.Linq; // !!

namespace WebApiPubs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublisherController : ControllerBase
    {
        // inyectar relación de dependencia
        private readonly PubsContext _context;
        public PublisherController(PubsContext context)
        {
            _context = context;
        }

        // GET /api/Publisher
        [HttpGet]
        public IEnumerable<Publisher> Get() 
        {
            // LinqToEntities --> Todos los publishers
            List<Publisher> publishers = (from p in _context.Publishers
                                          select p).ToList();  
            return publishers;
        }

        // GET  /api/publisher/id
        [HttpGet("{id}")]
        public Publisher Get(string id)
        {
            var publisher = (from p in _context.Publishers
                              where p.PubId == id
                              select p).SingleOrDefault();
            return publisher;
        }

        // GET  /api/publisher/city/state
        [HttpGet("{city}/{state}")]
        public IEnumerable<Publisher> Get(string city, string state) 
        {
            var publishers = (from p in _context.Publishers             // var o List<Publishers>
                              where p.City == city && p.State == state
                              select p).ToList();
            return publishers;
        }

        // GET  /api/publisher/city/state/country
        [HttpGet("{city}/{state}/{country}")]
        public dynamic Get(string city, string state, string country)
        {
            dynamic publisher = (from p in _context.Publishers
                                 where p.City == city && p.State == state &&
                                 p.Country == country
                                 select new { p.PubName, p.City, p.State, }
                                 );
            return publisher;
        }
    }
}
