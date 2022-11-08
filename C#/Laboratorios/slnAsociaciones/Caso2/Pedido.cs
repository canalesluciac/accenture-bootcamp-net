using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso2
{
    public class Pedido
    {
        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get; set; }
        public Cliente Cliente { get; set; }
    }
}
