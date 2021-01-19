using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FindRBeta.Models
{
    public class HousingValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var ad = (Ad)validationContext.ObjectInstance;

            int year = ad.HousingYear;

            bool cond;

            if(year >= DateTime.Now.Year)
            {
                cond = true;
            }
            else
            {
                cond = false;
            }

            return cond?ValidationResult.Success : new ValidationResult("Anul cazarii trebuie sa fie valid!");
        }

    }
}