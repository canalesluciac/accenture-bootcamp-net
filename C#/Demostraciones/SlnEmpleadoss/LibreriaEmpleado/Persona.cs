using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleado
{
    public abstract class Persona
    {
        #region Propiedades
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        #endregion

        #region Constructores
        public Persona(int Id, string Nombre, string Apellido) 
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
        }
        #endregion
    }
}
