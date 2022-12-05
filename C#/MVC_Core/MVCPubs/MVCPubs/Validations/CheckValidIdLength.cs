using System;
using System.ComponentModel.DataAnnotations;

namespace MVCPubs.Validations
{
    public class CheckValidIdLength: ValidationAttribute
    {
        public CheckValidIdLength()
        {

            ErrorMessage = "ID must be 4 characters long";
        }

        public override bool IsValid(object value)
        {
            string id = Convert.ToString(value);


            if (id.Length == 4)
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
