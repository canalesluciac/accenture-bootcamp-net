using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAsociaciones.Caso7
{
    public class Producto
    {
        #region Propiedades
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        // Propiedades de navegacion
        public List<DetalleFactura> DetalleFacturas { get; set; }
        public Categoria Categoria { get; set; }
        #endregion

        
        // SI NO SE USAN BORRAR LOS constructores !!!!!!

        #region Constructores

        public Producto() { }

        public Producto(string nombre, decimal precio)
        {
            this.Nombre = nombre;
            this.Precio = precio;
        }

        public Producto (string nombre, decimal precio, Categoria nombreCategoria)
        {
            this.Nombre = nombre;
            this.Precio = precio;
            this.Categoria = nombreCategoria;
        }
        #endregion
    }
}
