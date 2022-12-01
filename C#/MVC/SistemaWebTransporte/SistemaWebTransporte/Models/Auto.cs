using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using SistemaWebTransporte.Validaciones;

namespace SistemaWebTransporte.Models
{
    public class Auto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Modelo { get; set; }
        [Required]
        public string Marca { get; set; }
        [Required]
        [ValidacioAnioAtributo]
        public int Anio { get; set; }
        [Required]
        public string Color { get; set; }
    }
}