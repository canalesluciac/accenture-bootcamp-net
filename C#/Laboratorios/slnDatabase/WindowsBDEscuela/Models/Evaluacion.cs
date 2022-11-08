using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsBDEscuela.Models
{
    [Table("Evaluacion")]
    public class Evaluacion
    {
        public int EvaluacionId { get; set; }
        public int TipoId { get; set; }
        public int EstudianteId { get; set; }
        public int DetalleId { get; set; }
        public string Nota { get; set; }

        #region Propiedades de navegacion

        [ForeignKey("DetalleId")]
        public Detalle Detalle { get; set; }
        [ForeignKey("EstudianteId")]
        public Estudiante Estudiante { get; set; }
        public Tipo Tipo { get; set; }

        #endregion

    }
}
