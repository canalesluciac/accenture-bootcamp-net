using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace WindowsEFEscuela.Models
{
    [Table("Aulas")]
    public class Aula
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Capacidad { get; set; }

        [Required]
        [Column(TypeName = "char")]
        [StringLength(1)]
        public string Codigo { get; set; }

        public int IdMateria { get; set; } // Agregado por demostracion
        public int IdProfesor { get; set; } // Agregado por demostracion


        #region propiedades de navegación
        [ForeignKey("IdProfesor")] // Agregado por demostracion
        public Profesor Profesor { get; set; }
        public Materia Materia { get; set; }
        #endregion
    }
}
