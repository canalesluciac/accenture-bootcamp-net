using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAsociaciones.Caso5
{
    public class DatosContacto
    {
        #region Propiedades
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        //Propiedad de navegacion
        public Empleado Empleado { get; set; }
        public Cliente Cliente { get; set; }
        #endregion
    }
}
