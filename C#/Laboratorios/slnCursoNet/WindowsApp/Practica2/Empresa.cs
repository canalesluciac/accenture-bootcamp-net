using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Practica2
{
    public class Empresa
    {
        private string _Nombre;
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = "Pulgarcito"; }
        }

        private string _Domicilio;
        public string Domicilio
        {
            get { return _Domicilio; }
            set { _Domicilio = "Moreno 55"; }
        }

        private string _Ciudad;
        public string Ciudad 
        {
            get { return _Ciudad; }
            set { _Ciudad = "La Plata"; }
        }

        private int _Telefono;
        public int Telefono
        {
            get { return _Telefono; }
            set { _Telefono = 08002554; }
        }

        private string _SitioWeb;
        public string SitioWeb
        {
            get { return _SitioWeb; }
            set { _SitioWeb = "www.pulgarcito.com.ar"; }
        }

        private string _Producto;
        public string Producto
        {
            get { return _Producto; }
            set { _Producto = "mochilas"; }
        }
    }
}
