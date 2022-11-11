using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleado
{
    public class Empleado : Persona
    {
        public Empleado(int Id, string Nombre, string Apellido, string legajo) : base(Id, Nombre, Apellido)
        {
            Legajo = legajo;
        }

        public string Legajo { get; set; }
        public Departamento Departamento { get; set; }
    }
}
