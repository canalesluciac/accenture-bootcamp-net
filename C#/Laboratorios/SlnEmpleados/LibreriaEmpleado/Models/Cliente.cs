using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleado.Models
{
    public class Cliente : Persona
    {
        #region
        public Cliente(int id, string nombre, string apellido, string cuit, string telefono) : base(id, nombre, apellido)
        {
            Cuit= cuit;
            Telefono= telefono;
        }
        #endregion

        #region Propiedades
        public string Cuit { get; set; }
        public string Telefono { get; set; }
        #endregion
    }
}
