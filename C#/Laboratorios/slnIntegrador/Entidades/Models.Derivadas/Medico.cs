using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades.Models.Base;
namespace Entidades.Models.Derivadas
{
    public class Medico: Persona
    {
        #region Constructores
        public Medico(int id, string nombre, string apellido, string domicilio, string telefono, string email, string especialidad, string matricula) : base(id, nombre, apellido, domicilio, telefono, email)
        {
            Especialidad = especialidad;
            Matricula = matricula;
        }
        #endregion

        #region Propiedades
        public string Especialidad { get; set; }
        public string Matricula { get; set; }
        #endregion
    }
}
