using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsBDEscuela.Models
{
    [Table("Curso")]
    public class Curso
    {
        public int CursoId { get; set; }
        public string Nombre { get; set; }

        #region Propiedades de navegacion

        public List<Planilla> Planillas { get; set; }

        #endregion
    }
}
