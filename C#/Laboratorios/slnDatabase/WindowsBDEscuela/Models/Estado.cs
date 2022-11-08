using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsBDEscuela.Models
{
    [Table("Estado")]
    public class Estado
    {
        public int EstadoId { get; set; }

        public string Nombre { get; set; }

        #region Propiedades de navegacion

        public List<Detalle> Detalles { get; set; }

        #endregion
    }
}
