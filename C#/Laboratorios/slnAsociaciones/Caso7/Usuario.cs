using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso7
{
    public class Usuario
    {
        public string usuario { get; set; }
        public string password { get; set; }

        //Propiedad de navegación
        public Cliente Cliente { get; set; }
    }
}
