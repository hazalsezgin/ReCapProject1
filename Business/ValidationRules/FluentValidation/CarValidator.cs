using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            //solid kurallarına uymalı
            RuleFor(c => c.BrandId).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThan(0);
           // RuleFor(c => c).Must(StartWithA);
            
        }

        private bool StartWithA(string arg)
        {
            //true dönerse kurala uygun false dönerse kurala uygun olmaz arg anlamı parametre 
           return arg.StartsWith("A");
        }
    }
}
