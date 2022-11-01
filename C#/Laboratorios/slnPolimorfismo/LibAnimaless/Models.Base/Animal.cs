using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAnimaless.Models.Base
{
    public abstract class Animal
    {
        public int Edad
        {
            get
            {
                int _Edad = 0;
                return _Edad;
            }
        }
        public double Altura
        {
            get
            {
                double _Altura = 0;
                return _Altura;
            }
        }
        public double Peso
        {
            get
            {
                double _Peso = 0;
                return _Peso;
            }
        }

        public virtual string Imprimir()
        {
            return "Edad: " + Edad + ", Altura: " + Altura + ", Peso: " + Peso;
        }

        public abstract string ImprimirComida();
    }
}
