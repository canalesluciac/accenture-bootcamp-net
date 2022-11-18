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
    public class HospitalController : ControllerBase
    {
        // inyectar relación de dependencia
        private readonly DBHospitalAPI _context;
        public HospitalController(DBHospitalAPI context)
        {
            _context = context;
        }

        //GET api/hospital            
        [HttpGet]
        public dynamic Get()
        {
            dynamic hospital = (from h in _context.Hospitales
                                select new { h.Nombre, h.Telefono, h.Num_Cama });
            return hospital;
        }

        //GET api/hospital/Num_Cama           
        [HttpGet("{numCama}")]
        public dynamic Get(int numCama)
        {
            dynamic hospital = (from h in _context.Hospitales
                                where h.Num_Cama > numCama
                                select new { h.Nombre, h.Telefono, h.Num_Cama });
            return hospital;
        }
    }
}
