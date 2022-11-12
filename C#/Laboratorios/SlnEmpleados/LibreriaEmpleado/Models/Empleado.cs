using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleado.Models
{
    //[Table("Empleado")]
    public class Empleado:Persona
    {
        #region Constructores
        public Empleado(int id, string nombre, string apellido, string legajo) : base(id, nombre, apellido)
        {
            Legajo= legajo;
        }
        public Empleado() { }
        #endregion

        public string Legajo { get; set; }

        public Departamento Departamento { get; set; }                      //virtual?
    }
}
