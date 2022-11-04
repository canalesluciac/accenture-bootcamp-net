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
    public static class AdmMedico
    {
        static List<Medico> medicos;

        #region Mis Métodos
        public static List<Medico> Listar()
        {
            medicos = new List<Medico>();
            medicos.Add(new Medico(1, "Aaron", "Andradez", "Alcorta 123", "A123", "aaron@gmail.com", "Traumatologia", "AA11"));
            medicos.Add(new Medico(2, "Agustina", "Alamos", "Andreani 123", "A234", "agustina@gmail.com", "Pediatria", "A112"));
            medicos.Add(new Medico(3, "Augusto", "Adoratti", "Alamos 123", "A264", "augusto@gmail.com", "Clinica", "A142"));
            medicos.Add(new Medico(4, "Ana", "Acre", "Andreani 223", "A254", "ana@gmail.com", "Clinica", "A172"));
            medicos.Add(new Medico(5, "Anastasia", "Amigos", "Alabama 226", "A258", "anastasia@gmail.com", "Clinica", "A175"));
            return medicos;
        }

        public static List<Medico> Listar(string especialidad)
        {
            //TODO ...
            return null;
        }

        public static int Insertar(Medico medico)
        {
            //TODO ...
            return 0;
        }

        public static int Eliminar(int id)
        {
            //TODO ...
            return 0;
        }

        public static Medico TraerUno (int id)
        {
            //TODO ...
            return null;
        }
        #endregion

    }
}
