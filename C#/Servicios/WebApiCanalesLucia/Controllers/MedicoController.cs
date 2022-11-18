using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using WebApiCanalesLucia.Models;
using WebApiCanalesLucia.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace WebApiCanalesLucia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicoController : ControllerBase
    {
        // inyectar relación de dependencia
        private readonly DBHospitalAPI _context;
        public MedicoController(DBHospitalAPI context)
        {
            _context = context;
        }

        //GET api/medico            
        [HttpGet]
        public IEnumerable<Doctor> Get()
        {
            //LinqToEntities
            List<Doctor> doctors = (from d in _context.Doctores
                                    select d).ToList();
            return doctors;
        }

        // GET/api/medico/1                      // Todos los datos de UN medico por Doctor_No
        [HttpGet("{Doctor_No}")]
        public Doctor Get(int Doctor_No)
        {
            var doctor = (from d in _context.Doctores
                          where d.Doctor_No== Doctor_No
                          select d).SingleOrDefault();
            return doctor;
        }

        [HttpPost]
        public ActionResult Post (Doctor doctor)
        {
            _context.Doctores.Add(doctor);
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{Doctor_No}")]
        public ActionResult<Doctor> Delete(int Doctor_No)
        {
            Doctor doctor = _context.Doctores.Find(Doctor_No);
            if (doctor == null)
            {
                return NotFound(); // también podría ser NoContent();
            }
            _context.Doctores.Remove(doctor);
            _context.SaveChanges();
            return doctor;
        }

        [HttpPut("{Doctor_No}")]
        public ActionResult Put(int Doctor_No, [FromBody] Doctor doctor)
        {
            if (Doctor_No != doctor.Doctor_No) { return BadRequest(); }
            _context.Entry(doctor).State = EntityState.Modified;
            _context.SaveChanges();
            return NoContent(); 
        }

        [HttpGet("{especialidad}")]
        public IEnumerable<Doctor> Get(string especialidad)
        {
            //LinqToEntities
            List<Doctor> doctors = (from d in _context.Doctores
                                    where especialidad == d.Especialidad
                                    select d).ToList();
            return doctors;
        }
        
    }
}
