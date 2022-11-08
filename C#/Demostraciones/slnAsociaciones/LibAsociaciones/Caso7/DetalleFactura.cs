using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAsociaciones.Caso7
{
    public class DetalleFactura
    {
        #region Propiedades
        public string CodigoCompra { get; set; }

        //Propiedades de navegación
        public Factura Factura { get; set; }
        public Producto Producto { get; set; }
        #endregion
    }
}
