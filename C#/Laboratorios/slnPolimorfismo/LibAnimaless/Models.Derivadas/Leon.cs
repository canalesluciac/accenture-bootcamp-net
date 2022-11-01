using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibAnimaless.Models.Base;
namespace LibAnimaless.Models.Derivadas
{
    public class Leon : Animal
    {
        public override string ImprimirComida()
        {
            return "El leon come carne";
        }

        public string ColorPelaje { get; set; }
    }
}
