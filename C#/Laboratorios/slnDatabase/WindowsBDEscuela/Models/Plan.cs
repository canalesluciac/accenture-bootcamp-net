using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsBDEscuela.Models
{
    [Table("Plan")]
    public class Plan
    {
        public int PlanId { get; set; }
        public int CarreraId { get; set; }
        public string Nombre { get; set; }

        #region Propiedades de navegacion
        [ForeignKey("CarreraId")]
        public Carrera Carrera { get; set; }

        #endregion
    }
}
