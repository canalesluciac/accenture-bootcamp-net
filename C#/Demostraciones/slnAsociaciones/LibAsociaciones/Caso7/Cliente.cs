using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAsociaciones.Caso7
{
    public class Cliente:Persona
    {
        #region Propiedades
        public Usuario Usuario { get; set; }
        public List<Factura> Facturas { get; set; }
        #endregion
    }
}
