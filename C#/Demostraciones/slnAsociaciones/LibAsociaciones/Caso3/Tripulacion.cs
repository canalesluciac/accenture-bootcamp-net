using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAsociaciones.Caso3
{
    public class Tripulacion
    {
        #region Propiedades
        public int NumeroAvion { get; set; }

        //Propiedad de navegacion
        public List<Azafata> Azafatas { get; set; }
        #endregion
    }
}
