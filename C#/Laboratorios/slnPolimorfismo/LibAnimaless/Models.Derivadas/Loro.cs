using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibAnimaless.Models.Base;
namespace LibAnimaless.Models.Derivadas
{
    public class Loro : Animal
    {
        public override string ImprimirComida()
        {
            return "El loro come semillas";
        }

        public string PalabrasDominadas { get; set; }
    }
}
