using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAsociaciones.Caso6
{
    public class Director
    {
        #region Propiedades
        public string Nombre { get; set; }
        public string PostGrado { get; set; }

        //Propiedad de navegacion
        public Clinica Clinica { get; set; }
        #endregion
    }
}
