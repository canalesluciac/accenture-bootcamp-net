using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso7
{
    public class Empleado:Persona
    {
    
        public int Legajo { get; set; }

        //Propiedad de navegación
        public Factura Factura { get; set; }
    }
}
