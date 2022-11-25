using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace OperasWebSite.Validations
{
    public class CheckValidYear: ValidationAttribute
    {
        public CheckValidYear() // 3. Constructor
        {
            ErrorMessage = "La opera registrada más antigua es en 1598 de Rinuccini";
        }
        public override bool IsValid(object value) // override Is(tab tab)
        {
            int year = (int)value;           // 1. Variable YEAR local
            if (year < 1598)                // 2. Validación
            {
                return false;
            }
            else
            { return true; 
            }
            
        }
    }
}