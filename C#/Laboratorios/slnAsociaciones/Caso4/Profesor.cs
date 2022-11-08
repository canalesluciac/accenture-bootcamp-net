using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caso4
{
    public class Profesor
    {
        string Nombre { get; set; }
        string Apellido { get; set;  }
        string Materia { get; set; }
        List<Alumno> Alumnos { get; set; }
    }
}
