using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades.Models.Base;
namespace Entidades.Models.Derivadas
{
    public class Enfermero: Persona
    {
        #region Constructores
        public Enfermero(int id, string nombre, string apellido, string domicilio, string telefono, string email, int cuil) : base(id, nombre, apellido, domicilio, telefono, email)
        {
            CUIL=cuil;
        }
        #endregion

        #region Propiedades
        public int CUIL { get; set; }
        #endregion
    }
}
