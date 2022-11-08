using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAsociaciones.Caso4
{
    public class Profesor
    {
        #region Propiedades
        public string Nombre { get; set; }
        public string Materia { get; set; }
        public int Legajo { get; set; }

        // Propiedad de navegacion
        public List<Alumnos> Alumnos { get; set; }
        #endregion
    }
}
