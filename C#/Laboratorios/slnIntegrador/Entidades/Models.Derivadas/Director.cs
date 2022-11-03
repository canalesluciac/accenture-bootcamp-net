using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models.Derivadas
{
    public class Director:Medico
    {
        #region Constructores
        public Director(int id, string nombre, string apellido, string domicilio, string telefono, string email, string especialidad, string matricula, string postGrado) : base(id, nombre, apellido, domicilio, telefono, email, especialidad, matricula)
        {
            PostGrado = postGrado;
        }
        #endregion

        #region Propiedades
        public string PostGrado { get; set; }
        #endregion
    }
}
