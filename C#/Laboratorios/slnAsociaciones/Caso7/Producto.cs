using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso7
{
    public class Producto
    {
        public string Nombre { get; set; }
        public Decimal Precio { get; set; }


        //Propiedad de navegación
        public List<DetalleFactura> DetalleFacturas { get; set; }
        public Categoria Categoria { get; set; }

    }
}
