using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace WebApiCanalesLucia.Models
{
    [Table("Hospital")]     // TODO: Chequear
    public class Hospital
    {
        #region Propiedades
        [Key]
        [Required]
        public int Hospital_Cod { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Nombre { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Direccion { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Telefono { get; set; }

        public int Num_Cama { get; set; }
        #endregion

        #region Propiedades de navegación
        public List<Doctor> Doctores { get; set; }
        #endregion
    }
}
