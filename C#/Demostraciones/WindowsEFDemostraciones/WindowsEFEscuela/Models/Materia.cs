using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WindowsEFEscuela.Models
{
    [Table("Materias")]
    public class Materia
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Programa { get; set; }

        public int IdProfesor { get; set; } // Agregado en demostracion
        public int IdAula { get; set; } // Agregado en demostracion

        #region propiedades de navegación
        [ForeignKey("IdProfesor")] // Agregado en demostracion
        public Profesor Profesor { get; set; }
        public Aula Aula { get; set; }
        #endregion
    }
}
