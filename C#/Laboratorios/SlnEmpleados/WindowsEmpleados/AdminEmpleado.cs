using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibreriaEmpleado.Models;
namespace WindowsEmpleados
{
    public static class AdminEmpleado
    {
        static List<Empleado> list = new List<Empleado> ();

        public static void Insertar (Empleado empleado)
        {
            list.Add(empleado);
        // Si no se padara un empleado por parámetro, sería opción --> Empleado empleado = new Empleado() { Id = 1, Nombre = "Ana", Apellido = "Arana", Legajo = "1111" };
        }
        
        public static List<Empleado> Listar ()
        {
            return list;
        }

        
    }
}
