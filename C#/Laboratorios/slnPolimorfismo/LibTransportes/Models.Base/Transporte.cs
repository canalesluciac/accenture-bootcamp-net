using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Models.Base
{
    public abstract class Transporte
    {
        public int MaxFuel { get; set; }
        public int MaxNroDePasajeros { get; set; }
        public double Velocidad { get; set; }

        public virtual string Acelerar()
        {
            return "acelera";
        }
        public virtual string Desacelerar()
        {
            return "desacelera";
        }
        public virtual string DoblarAIzq()
        {
            return "dobla a la izquierda";
        }
        public virtual string DoblarADcha()
        {
            return "dobla a la derecha";
        }
    }
}
