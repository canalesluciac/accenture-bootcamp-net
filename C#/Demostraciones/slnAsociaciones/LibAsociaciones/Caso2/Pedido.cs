using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAsociaciones.Caso2
{
    public class Pedido
    {
        #region Propiedades
        public string Producto { get; set; }

        //Propiedad de navegacion
        public Cliente Cliente { get; set; }
        #endregion
    }
}
