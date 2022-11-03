using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades.Models.Derivadas;

namespace Negocio
{
    public class AdmPaciente
    {
        List<Paciente> pacientes;

        public List<Paciente> Listar()
        {
            pacientes = new List<Paciente>();
            pacientes.Add(new Paciente() { Id=1, Nombre="Hector", Apellido="AAA", Email="hector@gmail.com", Domicilio="Caballito 123", NroHistoriaClinica="1234", Telefono="1111"});
            pacientes.Add(new Paciente() { Id = 1, Nombre = "Gabriel", Apellido = "BBB", Email = "gabriel@gmail.com", Domicilio = "Formosa 123", NroHistoriaClinica = "1235", Telefono = "222" });
            pacientes.Add(new Paciente() { Id = 1, Nombre = "Ulises", Apellido = "CCC", Email = "ulises@gmail.com", Domicilio = "Moreno 123", NroHistoriaClinica = "1236", Telefono = "3333" });
            pacientes.Add(new Paciente() { Id = 1, Nombre = "Mara", Apellido = "Gonzalez", Email = "mara@gmail.com", Domicilio = "San Martin 123", NroHistoriaClinica = "1237", Telefono = "4444" });
            pacientes.Add(new Paciente() { Id = 1, Nombre = "Candela", Apellido = "Gonzalez", Email = "candela@gmail.com", Domicilio = "Belgrano 123", NroHistoriaClinica = "1238", Telefono = "555" });
            return pacientes;
        }

        public int Insertar(Paciente paciente)
        {
            //TODO ...
            return 0;
        }

        public int Eliminar(int id)
        {
            //TODO ...
            return 0;
        }

        public Paciente TraerUno(int id)
        {
            //TODO ...
            return null;
        }

    }
}
