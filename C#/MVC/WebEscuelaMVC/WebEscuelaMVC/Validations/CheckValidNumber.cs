using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebEscuelaMVC.Validations
{
    public class CheckValidNumber: ValidationAttribute
    {
        public CheckValidNumber() 
        {
            ErrorMessage= "El numero debe ser mayor a 100";
        }
        public override bool IsValid(object value)
        {
            int numero = (int)value;
            if (numero < 100) 
            {
                return false;
            }
            return true;
        }
    }
}