using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Web;

namespace SimpleMVC.Attributes
{
    public class ScoreValidAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            object instance = validationContext.ObjectInstance;
            Type type = instance.GetType();
            var hold2 =  type.GetProperty("Hold2").GetValue(instance).ToString();
            int hold1score = Int32.Parse(type.GetProperty("Hold1Score").GetValue(instance).ToString());
            int hold2score = Int32.Parse(type.GetProperty("Hold2Score").GetValue(instance).ToString());

            if(hold1score+hold2score!=10)
                return new ValidationResult("Summen af score skal være = 10");

            if( (value.ToString().ToLower().Contains("john") && hold1score>hold2score && hold2.ToLower().Contains("mini jacob")))
                return new ValidationResult("John kan ikke vinde over Michael & Jacob");

            return null;
        }
    }
}

