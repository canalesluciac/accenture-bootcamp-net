using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsBDEscuela.Models
{
    [Table("Materia")]
    public class Materia
    {
        public int MateriaId { get; set; }
        public string Nombre { get; set; }

        #region Propiedades de navegacion

        public List<Planilla> Planillas { get; set; }

        #endregion
    }
}
