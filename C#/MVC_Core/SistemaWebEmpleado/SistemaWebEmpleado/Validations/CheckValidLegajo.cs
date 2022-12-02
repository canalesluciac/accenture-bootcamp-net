using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp;
using System;

namespace SistemaWebEmpleado.Validations

{
    public class CheckValidLegajo: ValidationAttribute
    {
        public CheckValidLegajo() {

            ErrorMessage = "El legajo debe comenzar con dos letras AA y 5 numeros";
        }

        public override bool IsValid(object value) 
        {
            string legajo = Convert.ToString(value);


            if (legajo.Substring(0, 2) == "AA" && int.TryParse(legajo.Replace("AA", ""), out int numLegajo) && legajo.Replace("AA", "").Length == 5)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }

}
