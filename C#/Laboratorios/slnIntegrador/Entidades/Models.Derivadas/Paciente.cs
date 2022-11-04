using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades.Ayudantes;
using Entidades.Models.Base;
namespace Entidades.Models.Derivadas
{
    public class Paciente: Persona
    {
        #region Constructores
        public Paciente(int id, string nombre, string apellido, string domicilio, string telefono, string email, string nroHistoriaClinica, DateTime fechaNacimiento) : base(id, nombre, apellido, domicilio, telefono, email)
        {
            NroHistoriaClinica = nroHistoriaClinica;
            _FechaNacimiento = fechaNacimiento;
        }
        #endregion

        #region Propiedades
        public string NroHistoriaClinica { get; set; }
        
        /// <summary>
        /// Tarea 7: Se declara propiedad FechaNacimiento de solo lectura
        /// </summary>
        private DateTime _FechaNacimiento;
        public DateTime FechaNacimiento
        {
            get { return _FechaNacimiento; }
        }

        /// <summary>
        /// Tarea 7: Se declara propiedad Edad de solo lectura. Se utiliza para ella el método CalcularEdad
        /// </summary>
        public int Edad
        {
            get { return UtilidadesFechas.CalcularEdad(FechaNacimiento); }
        }
        #endregion
    }
}
