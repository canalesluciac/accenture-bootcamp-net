using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAsociaciones.Caso2
{
    public class Cliente
    {
        #region Propiedades
        public string Identificacion { get; set; }
        
        //Propiedad de navegacion
        public List<Pedido> Pedidos { get; set; }
        #endregion
    }
}
