using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OperasWebSite.Validations;

namespace OperasWebSite.Models
{
    public class Opera
    {
        public int OperaId { get; set; }

        [Required(ErrorMessage = "Campo obligatorio")] // MENSAJE ERROR CDO USUARIO NO COMPLETA EL TITULO
        [Column(TypeName = "varchar")] // EL varchar(50) ES EN CORE OJO
        [StringLength(50)]
        public string Title { get; set; }

        [Required]

        public string Compositor { get; set;}

        [CheckValidYear]
        public int Year { get; set; }
    }
}

/*
 *  1RO MODELOS Y PROPIEDADES
 *  2. DATA NOTATIONS
 *  USING using System.ComponentModel.DataAnnotations;
        using System.ComponentModel.DataAnnotations.Schema;
 */