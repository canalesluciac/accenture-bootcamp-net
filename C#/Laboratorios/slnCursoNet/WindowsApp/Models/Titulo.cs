using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Models
{
    public class Titulo
    {
        public string NombreAutor { get; set; }
        public string TituloAtributo { get; set; }
        public string Categoria { get; set; }
        public double Precio { get; set; }
        public string Notas { get; set; } /* ¿Notas numéricas o notas de block de notas?*/
    }
}
