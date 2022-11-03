using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades.Models.Derivadas;

namespace Negocio
{
    public class AdmHabitacion
    {
        List<Habitacion> habitaciones;

        public List<Habitacion> Listar()
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

        public List<Habitacion> Listar(string estado)
        {
            //TODO ...
            return null;
        }

        public int Insertar(Habitacion habitacion)
        {
            //TODO ...
            return 0;
        }

        public int Eliminar(int id)
        {
            //TODO ...
            return 0;
        }

        public Habitacion TraerUno (int id)
        {
            //TODO ...
            return null;
        }

    }
}
