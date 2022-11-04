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
    public static class AdmPaciente
    {
        static List<Paciente> pacientes;

        #region Mis Métodos
        public static List<Paciente> Listar()
        {
            pacientes = new List<Paciente>();
            pacientes.Add(new Paciente(1, "Martina", "Gomez", "Tejedor 123", "1234", "martina@gmail.com", "A123", new DateTime(1995, 4, 2)));
            pacientes.Add(new Paciente(1, "Hector", "Perez", "Pasteur 123", "1235", "hector@gmail.com", "A126", new DateTime(1997, 6, 15)));
            pacientes.Add(new Paciente(1, "Gabriel", "Gonzalez", "Arenales 123", "1236", "gabriel@gmail.com", "A167", new DateTime(2000, 5, 22)));
            pacientes.Add(new Paciente(1, "Ulises", "Lopez", "San Martin 123", "1237", "ulises@gmail.com", "A873", new DateTime(1975, 6, 1)));
            pacientes.Add(new Paciente(1, "Mara", "Juarez", "Belgrano 123", "1238", "mara@gmail.com", "A194", new DateTime(1990, 8, 11)));
            pacientes.Add(new Paciente(1, "Candela", "Michelli", "Moreno 123", "1230", "candela@gmail.com", "A154", new DateTime(1968, 1, 16)));
            return pacientes;
        }

        public static int Insertar(Paciente paciente)
        {
            //TODO ...
            return 0;
        }

        public static int Eliminar(int id)
        {
            //TODO ...
            return 0;
        }

        public static Paciente TraerUno(int id)
        {
            //TODO ...
            return null;
        }
        #endregion

    }
}
