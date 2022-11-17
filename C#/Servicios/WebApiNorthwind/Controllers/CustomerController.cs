using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using WebApiNorthwind.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace WebApiNorthwind.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        // inyectar relación de dependencia
        private readonly NorthwindContext _context;
        public CustomerController(NorthwindContext context)
        {
            _context = context;
        }

        // GET  api/Customer
        [HttpGet]
        public IEnumerable<Customer> Get() 
        {
            List<Customer> customers = (from c in _context.Customers // requiere using System.Linq
                                        select c).ToList();
            return customers;
        }

        // GET api/customer/id
        [HttpGet("{CustomerId}")]
        public Customer Get(string CustomerId)
        {
            var customer = (from c in _context.Customers
                            where c.CustomerId == CustomerId
                            select c).SingleOrDefault();
            return customer;
        }

        // GET  api/customer/company/contract
        [HttpGet("{CompanyName}/{ContractName}")]
        public dynamic Get(string CompanyName, string ContractName)
        {
            dynamic customer = (from c in _context.Customers
                                where c.CompanyName== CompanyName && c.ContactName== ContractName
                                select new {c.CompanyName, c.ContactName, c.ContactTitle, c.Phone});
            return customer;
        }

        [HttpPost]
        public ActionResult Post(Customer customer) 
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return Ok();
        }

        [HttpPut("{CustomerId}")]
        public ActionResult Put(string CustomerId, [FromBody] Customer customer) 
        {
            if (CustomerId != customer.CustomerId) { return BadRequest(); }
            _context.Entry(customer).State= EntityState.Modified;
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{CustomerId}")]
        public ActionResult<Customer> Delete(string CustomerId) 
        {
            var customer = _context.Customers.Find(CustomerId);
            if (customer == null)
            {
                return NoContent();
            }
            _context.Customers.Remove(customer);
            _context.SaveChanges();
            return customer;
        }


    }
}
