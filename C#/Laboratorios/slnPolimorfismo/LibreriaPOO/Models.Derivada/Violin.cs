using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibreriaPOO.Models.Base;
namespace LibreriaPOO.Models.Derivada
{
    public class Violin:InstrumentoMusical
    {
        public override string Afinar()
        {
            return "Afinando Violin";
        }
    }
}