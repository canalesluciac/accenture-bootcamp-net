using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Entidades
{
    public class Remito : DocumentoComercial
    {
        public Remito(string numero, DateTime fecha, string cliente, string direccion, string condicionIVA, string condicionVenta, string detalle, decimal total, DateTime fechaEntrega) : base(numero, fecha, cliente, direccion, condicionIVA, condicionVenta, detalle, total)
        {
            FechaEntrega = fechaEntrega;
        }
        public DateTime FechaEntrega { get; set; }

    }
}
