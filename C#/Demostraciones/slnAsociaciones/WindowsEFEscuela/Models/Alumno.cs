using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace WindowsEFEscuela.Models
{
    [Table("Alumnos")]
    public class Alumno
    {
        #region Propiedades
        [Required]
        public int AlumnoId { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Nombre { get; set; }
        
        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Apellido { get; set; }


        public DateTime? FechaNacimiento { get; set; }

        #endregion

        #region propiedades de navegación
        public Profesor Profesor { get; set; }
        #endregion
    }
}
