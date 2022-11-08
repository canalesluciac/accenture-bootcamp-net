using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAsociaciones.Caso7
{
    public class Empleado:Persona
    {
        #region Propiedades
        public string Legajo { get; set; }
        
        //Propiedad de navegacion
        public Factura Factura { get; set; }
        #endregion
    }
}
