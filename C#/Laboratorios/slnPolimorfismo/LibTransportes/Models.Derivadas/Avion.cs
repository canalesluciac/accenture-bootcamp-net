using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibTransportes.Models.Base;
namespace LibTransportes.Models.Derivadas
{
    public class Avion:Transporte
    {
        public double maxAltitud { get; set; }
        public int nroDeMotores { get; set; }

        public override string Acelerar()
        {
            return "el avion " + base.Acelerar();
        }

        public override string Desacelerar()
        {
            return "el avion " + base.Desacelerar();
        }

        public override string DoblarADcha()
        {
            return "el avion " + base.DoblarADcha();
        }

        public override string DoblarAIzq()
        {
            return "el avion " + base.DoblarAIzq();
        }
    }
}
