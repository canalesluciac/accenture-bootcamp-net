using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsBDEscuela.Models
{
    [Table("Planilla")]
    public class Planilla
    {
        public int PlanillaId { get; set; }
        public int CarreraId { get; set; }
        public int MateriaId { get; set; }
        public int ProfesorId { get; set; }
        public int CursoId { get; set; }
        public DateTime Fecha { get; set; }

        #region Propiedades de navegacion

        public List<Detalle> Detalles { get; set; }
        [ForeignKey("CarreraId")]
        public Carrera Carrera { get; set; }
        [ForeignKey("MateriaId")]
        public Materia Materia { get; set; }
        [ForeignKey("ProfesorId")]
        public Profesor Profesor { get; set; }
        [ForeignKey("CursoId")]
        public Curso Curso { get; set; }



        #endregion
    }
}
