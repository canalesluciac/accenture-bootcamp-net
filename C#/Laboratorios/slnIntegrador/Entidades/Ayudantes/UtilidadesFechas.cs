using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades.Models.Derivadas;
namespace Entidades.Ayudantes
{
    /// <summary>
    /// Tarea 7. Agregada la clase estática UtilidadesFechas
    /// </summary>
    public static class UtilidadesFechas
    {
        public static int CalcularEdad(DateTime fechaNacimiento)
        {;
            DateTime FechaActual = DateTime.Now;
            int edad = FechaActual.Year - fechaNacimiento.Year;
            if ((fechaNacimiento.Month > FechaActual.Month) || (fechaNacimiento.Month==FechaActual.Month && fechaNacimiento.Day>FechaActual.Day))
            {
                edad -= - 1;
            }
            return edad;
        }
    }
}
