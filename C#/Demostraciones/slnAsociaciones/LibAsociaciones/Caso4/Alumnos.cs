using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAsociaciones.Caso4
{
    public class Alumnos
    {
        #region Propiedades
        public string Nombre { get; set; }

        //Propiedad de navegacion
        public Profesor Profesor { get; set; }
        #endregion
    }
}
