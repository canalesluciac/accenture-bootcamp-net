using System;
using System.Linq;
using System.Web;

using System.Collections.Generic;
using System.Web.DynamicData;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebElReyCan.Models
{
    [Table("Turno")]
    public class Turno
    {
        #region Propiedades
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(10)]
        public string Fecha { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(10)]
        public string Hora { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string Nombre { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(40)]
        public string Raza { get; set; }
        public int Edad { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [DisplayName("Dueño")]
        public string NombreDuenio { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string Celular { get; set; }
        #endregion
    }
}