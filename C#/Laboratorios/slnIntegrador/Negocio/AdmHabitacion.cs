using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades.Models.Derivadas;

namespace Negocio
{
    /// <summary>
    /// Tarea 6: Se convierte a clase estática (y miembros estáticos)
    /// </summary>
    public static class AdmHabitacion
    {
        static List<Habitacion> habitaciones;

        #region Mis Métodos
        public static List<Habitacion> Listar()
        {
            //Crear lista
            habitaciones = new List<Habitacion>();

            //Crear objetos - Notación declarativa
            Habitacion habitacion = new Habitacion() { Id=1, Numero=1, Estado="Ocupado"};
            //Agregar objeto ya creado a la lista
            habitaciones.Add(habitacion);

            // Crear y agregar - Tipo anónimo
            habitaciones.Add(new Habitacion() { Id=2, Numero=2, Estado="Disponible"});
            habitaciones.Add(new Habitacion() { Id = 3, Numero = 3, Estado = "Disponible" });
            habitaciones.Add(new Habitacion() { Id = 4, Numero = 4, Estado = "Disponible" });
            habitaciones.Add(new Habitacion() { Id = 5, Numero = 5, Estado = "Ocupado" });
            return habitaciones;
        }

        public static List<Habitacion> Listar(string estado)
        {
            //TODO ...
            return null;
        }

        public static int Insertar(Habitacion habitacion)
        {
            //TODO ...
            return 0;
        }

        public static int Eliminar(int id)
        {
            //TODO ...
            return 0;
        }

        public static Habitacion TraerUno (int id)
        {
            //TODO ...
            return null;
        }
        #endregion

    }
}
