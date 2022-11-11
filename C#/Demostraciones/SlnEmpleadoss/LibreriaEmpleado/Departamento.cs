using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleado
{
    public class Departamento
    {
        #region Propiedades
        public string Id { get; set; }
        public string Nombre { get; set; }
        #endregion

        #region Navegacion
        public List<Empleado> Empleados { get; set;}
        #endregion
    }
}
