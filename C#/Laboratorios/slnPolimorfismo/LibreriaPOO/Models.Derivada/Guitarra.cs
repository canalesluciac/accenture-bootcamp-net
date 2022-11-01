using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibreriaPOO.Models.Base;
namespace LibreriaPOO.Models.Derivada
{
    public class Guitarra:InstrumentoMusical
    {
        public override string Afinar()
        {
            return "Afinando Guitarra";
        }
        
    }
}
