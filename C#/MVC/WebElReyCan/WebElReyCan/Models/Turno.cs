using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebElReyCan.Models
{
    public class Turno
    {
        public string Fecha { get; set; }
        public string Hora { get; set; }

        [Required]
        public string Nombre { get; set; }
        public string Raza { get; set; }
        public int Edad { get; set; }
        public string NombreDuenio { get; set; }   
        public string Celular { get; set; }
    }
}