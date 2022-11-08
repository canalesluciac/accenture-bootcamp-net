using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsBDEscuela.Models
{
    [Table("Tipo")]
    public class Tipo
    {
        public int TipoId { get; set; }
        public int LocalidadId { get; set; }

        #region Propiedades de navegacion

        public List<Evaluacion> Evaluaciones { get; set; }

        #endregion
    }

}
