using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAsociaciones.Caso1
{
    public class Usuario
    {
        #region Propiedades
        public string Nombre { get; set; }
        public string Password { get; set; }

        //Propiedad de navegacion
        public Cliente Cliente { get; set; }
        #endregion
    }
}
