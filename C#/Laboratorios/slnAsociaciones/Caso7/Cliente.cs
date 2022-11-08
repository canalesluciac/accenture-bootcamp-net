using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso7
{
    public class Cliente:Persona
    {
        //Propiedad de navegación
        public List<Factura> Facturas { get; set; }
        public Usuario Usuario { get; set; }
    }
}
