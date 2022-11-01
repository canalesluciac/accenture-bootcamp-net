using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibTransportes.Models.Base;
namespace LibTransportes.Models.Derivadas
{
    public class Auto:Transporte
    {
        public string Modelo { get; set; }

        public override string Acelerar()
        {
            return "el auto " + base.Acelerar();
        }

        public override string Desacelerar()
        {
            return "el auto " + base.Desacelerar();
        }

        public override string DoblarADcha()
        {
            return "el auto " + base.DoblarADcha();
        }

        public override string DoblarAIzq()
        {
            return "el auto " + base.DoblarAIzq();
        }
    }
}
