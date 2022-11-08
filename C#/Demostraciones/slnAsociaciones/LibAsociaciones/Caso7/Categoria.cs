using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAsociaciones.Caso7
{
    public class Categoria
    {
        #region Propiedades
        public string Nombre { get; set; }

        //Propiedades de navegación
        public List<Producto> Productos { get; set; }
        #endregion

        #region Constructores
        public Categoria() { }

        public Categoria(string nombre, List<Producto> productos)
        {
            Nombre = nombre;
            this.Productos = productos;
        }

        #endregion
    }
}
