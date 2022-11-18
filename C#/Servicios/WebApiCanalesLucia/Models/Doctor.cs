using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiCanalesLucia.Models

{
    [Table("Doctor")]       // TODO: Chequear
    public class Doctor
    {
        [Key] // ForeignKey("Hospital_Cod")
        [Required]
        public int Doctor_No { get; set; }

        [Required]
        public int Hospital_Cod { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Apellido { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Especialidad { get; set; }

        #region Propiedades de navegación
        public Hospital Hospital { get; set; }
        #endregion
    }
}
