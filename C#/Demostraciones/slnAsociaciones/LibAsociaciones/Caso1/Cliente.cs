using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAsociaciones.Caso1
{
    public class Cliente
    {
        #region Propiedades
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        //Propiedad de navegacion
        public Usuario Usuario { get; set; }
        #endregion
    }
}
