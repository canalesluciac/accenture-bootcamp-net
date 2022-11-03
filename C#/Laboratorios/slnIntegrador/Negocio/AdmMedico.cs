using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades.Models.Derivadas;

namespace Negocio
{
    /// <summary>
    /// Fase 2: Se convierte a clase estática (y miembros estáticos)
    /// </summary>
    public static class AdmMedico
    {
        static List<Medico> medicos;

        public static List<Medico> Listar()
        {
            medicos = new List<Medico>();
            medicos.Add(new Medico() { Id = 0, Nombre = "Lucia", Apellido = "Canales", Domicilio = "Accenture 123", Email = "lucia@gmail.com", Especialidad = "Pediatria", Matricula = "12345", Telefono = "123456" });
            medicos.Add(new Medico() { Id = 1, Nombre = "Susana", Apellido = "Fernandez", Domicilio = "Accenture 123", Email = "susana@gmail.com", Especialidad = "Clinica", Matricula = "12349", Telefono = "123450" });
            medicos.Add(new Medico() { Id = 1, Nombre = "Gregorio", Apellido = "Fernandez", Domicilio = "Accenture 123", Email = "gregorio@gmail.com", Especialidad = "Clinica", Matricula = "12346", Telefono = "123457" });
            medicos.Add(new Medico() { Id = 3, Nombre = "Gabriela", Apellido = "Giles", Domicilio = "EducacionIt 123", Email = "gabriela@gmail.com", Especialidad = "Clinica", Matricula = "12348", Telefono = "123459" });
            medicos.Add(new Medico() { Id = 2, Nombre = "Bautista", Apellido = "Fernandez", Domicilio = "Accenture 123", Email = "bautista@gmail.com", Especialidad = "Traumatologia", Matricula = "12347", Telefono = "123458" });
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

    }
}
