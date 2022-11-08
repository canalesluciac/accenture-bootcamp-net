using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso7
{
    public class DetalleFactura
    {
        public string CodigoCompra { get; set; }

        //Propiedad de navegación
        public Producto Producto { get; set; }
        public Factura Factura { get; set; }
    }
}
