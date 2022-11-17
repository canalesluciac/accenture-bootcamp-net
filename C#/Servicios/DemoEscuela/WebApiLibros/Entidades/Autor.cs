using System;
using System.Collections.Generic;
// using System.ComponentModel.DataAnnotations;

namespace WebApiLibros.Entidades
{
    public class Autor
    {
        public int Id { get; set; }

        // [Required] Requerido en versiones previas a 2.1
        public string Name { get; set; }
    }
}
