using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAsociaciones.Caso7
{
    public class Usuario
    {
        #region Propiedades
        public string nUsuario { get; set; }
        public string Password { get; set; }

        //Propiedad de navegacion
        public Cliente cliente { get; set; }
        #endregion
    }
}
