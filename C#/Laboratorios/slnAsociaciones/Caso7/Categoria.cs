using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso7
{
    public class Categoria
    {
        public string Nombre { get; set; }


        //Propiedad de navegación
        public List<Producto> Producto { get; set; }
    }
}
