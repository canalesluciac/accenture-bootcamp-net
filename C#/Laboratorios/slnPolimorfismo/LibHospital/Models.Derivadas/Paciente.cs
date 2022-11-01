using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibHospital.Models.Base;
namespace LibHospital.Models.Derivadas
{
    public class Paciente : Persona
    {
        public Paciente(string nombre, string historiaClinica) : base(nombre)
        {
            HistoriaClinica = historiaClinica;
        }

        public string HistoriaClinica { get; set; }

        public override string ToString()
        {
            return base.ToString() + ", " + HistoriaClinica;
        }
    }
}
