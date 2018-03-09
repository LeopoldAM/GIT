using System;
using System.ComponentModel.DataAnnotations;

namespace AspMVC.Models
{
    public class ValidatorCarAttribute : RegularExpressionAttribute
    {
        public ValidatorCarAttribute() : base("^([a-zA-Z]*[ ]*)*$")
        {
            
        }
    }
}