using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApiNorthwind.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace WebApiNorthwind.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        // inyectar relación de dependencia
        private readonly NorthwindContext _context;
        public CategoriaController(NorthwindContext context)
        {
            _context = context;
        }
        
        // GET  api/Categoria
        [HttpGet]
        public dynamic Get()
        {
            dynamic category = (from c in _context.Categories
                                select new { c.CategoryName});
            return category;
        }

        // GET  api/Categoria/CategoryId
        [HttpGet("{CategoryId}")]
        public dynamic Get(int CategoryId)
        {
            dynamic category = (from c in _context.Categories
                                where c.CategoryId == CategoryId
                                select new { c.CategoryName });
            return category;
        }
        
        /*[HttpGet]
        public IEnumerable<Category> Get()
        {
            List<Category> categories = (from c in _context.Categories // requiere using System.Linq
                                        select c).ToList();
            return categories;
        }*/
    }
}
