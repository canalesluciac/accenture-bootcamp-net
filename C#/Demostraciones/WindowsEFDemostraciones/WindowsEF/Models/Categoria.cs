using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WindowsEF.Models
{
    [Table("Categoria")]
    public class Categoria
    {
        //EF convención: Id, ID, o CategoriaId automáticamente es PK

        public int Id { get; set; }

        [Required]  //campo obligatorio - DB: NOT NULL
        [Column(TypeName = "varchar")] // tipo de dato de SQLServer
        [StringLength(50)] // Longitud máxima de la cadena
        public string Nombre { get; set; }

        #region propiedades de navegación
        public List<Producto> Productos { get; set; }
        #endregion

    }
}
