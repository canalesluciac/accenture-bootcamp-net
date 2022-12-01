using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebElReyCan.Models
{
    public class Turno
    {
        public int Id { get; set; }
        public string Fecha { get; set; }
        public string Hora { get; set; }

        [Required]
        public string Nombre { get; set; }
        public string Raza { get; set; }
        public int Edad { get; set; }
        [Required]
        public string NombreDuenio { get; set; }
        [Required]
        public string Celular { get; set; }
    }
}