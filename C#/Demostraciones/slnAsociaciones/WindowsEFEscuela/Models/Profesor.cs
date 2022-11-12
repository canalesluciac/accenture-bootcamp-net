using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace WindowsEFEscuela.Models
{
    [Table("Profesores")]
    public class Profesor
    {
        #region

        public int ProfesorId { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Apellido { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Titulo { get; set; }

                                                                    //public int IdProfesor { get; set; }
        #endregion

        #region Propiedades de navegación
                                                                    //[ForeignKey("IdProfesor")]
        public List<Alumno> Alumnos { get; set; }
        public List<Materia> Materias { get; set; }
        public Aula Aula { get; set; }
        #endregion
    }
}
