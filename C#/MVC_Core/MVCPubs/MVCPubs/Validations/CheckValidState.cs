using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using Microsoft.CodeAnalysis.CSharp;
using System;


namespace MVCPubs.Validations
{
    public class CheckValidState: ValidationAttribute
    {
        public CheckValidState()
        {

            ErrorMessage = "Maximum length allowed: 2 letters";
        }

        public override bool IsValid(object value)
        {
            string state = Convert.ToString(value);


            if (state.Length == 2)
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
