using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso5
{
    public class DatosContacto
    {
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public Cliente Cliente;
        public Empleado Empleado; 
    }
}
