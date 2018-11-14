using AdminServices;
using System;
using System.ComponentModel.DataAnnotations;

namespace WebshopAdmin.App_Code
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false)]
    public sealed class EmailValidationAttribute : ValidationAttribute
    {

        public override bool IsValid(object value)
        {
            return GraphisoftEmailValidator.IsValid(value.ToString());
        }
        public override string FormatErrorMessage(string name)
        {
            return string.Format(ErrorMessageString, name);
        }


    }

}