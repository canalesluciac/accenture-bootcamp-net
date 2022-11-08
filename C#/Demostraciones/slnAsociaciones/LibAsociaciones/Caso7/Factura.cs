using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAsociaciones.Caso7
{
    public class Factura
    {
        #region Propiedades
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }

        //Propiedad de navegacion
        public Cliente Cliente { get; set; }
        public Empleado Empleado { get; set; }
        public List<DetalleFactura> DetalleFacturas { get; set; }
        #endregion
    }
}
