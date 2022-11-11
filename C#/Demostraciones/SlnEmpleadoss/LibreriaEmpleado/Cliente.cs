using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleado
{
    public class Cliente : Persona
    {
        #region Constructores
        public Cliente(int Id, string Nombre, string Apellido, string cuit, string telefono) : base(Id, Nombre, Apellido)
        {
            Cuit = cuit;
            Telefono = telefono;
        }
        #endregion

        public string Cuit { get; set; }
        public string Telefono { get; set; }
    }
}
