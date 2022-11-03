using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades.Models.Base;
namespace Entidades.Models.Derivadas
{
    public class Enfermero: Persona
    {
        public int CUIL { get; set; }
    }
}
