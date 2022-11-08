using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAsociaciones.Caso6
{
    public class Clinica
    {
        #region Propiedades
        public int Id { get; set; }
        public string Nombre { get; set; }

        //Propiedad de navegacion
        public Director Director { get; set; }
        #endregion
    }
}
