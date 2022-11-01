using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibAnimaless.Models.Base;
namespace LibAnimaless.Models.Derivadas
{
    public class Conejo : Animal
    {
        public override string ImprimirComida()
        {
            return "El conejo come zanahoria";
        }

        public double TamanioDientes { get; set; }
    }
}
