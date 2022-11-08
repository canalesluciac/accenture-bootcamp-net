using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso5
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CUIL { get; set; }

        public List<DatosContacto> DatosContactos;
    }
}
