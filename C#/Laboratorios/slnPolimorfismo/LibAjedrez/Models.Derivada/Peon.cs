using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibAjedrez.Models.Base;
namespace LibAjedrez.Models.Derivada
{
    public class Peon:PiezaAjedrez
    {
        public override string Mover()
        {
            return "El peon tiene movimiento en diagonal";
        }
    }
}
