using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibAjedrez.Models.Base;
namespace LibAjedrez.Models.Derivada
{
    public class Torre:PiezaAjedrez
    {
        public override string Mover()
        {
            return "La torre tiene movimiento recto";
        }
    }
}
