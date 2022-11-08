using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAsociaciones.Caso3
{
    public class Azafata
    {
        #region Propiedades
        public string Nombre { get; set; }

        //Propiedad de navegacion
        public Tripulacion Tripulacion { get; set; }
        #endregion
    }
}
