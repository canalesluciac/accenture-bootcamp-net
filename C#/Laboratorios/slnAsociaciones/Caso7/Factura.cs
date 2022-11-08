using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso7
{
    public class Factura
    {
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }

        //Propiedad de navegación
        public Cliente Cliente { get; set; }
        public List<DetalleFactura> DetalleFacturas;
  public Empleado Empleado { get; set; }
    }
}
