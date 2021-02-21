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
            
            RuleFor(c => c.Description).MinimumLength(2).WithMessage("Descriptom must min 2 character");
            RuleFor(c => c.DailyPrice).GreaterThan(0).WithMessage("Dailyprice must min. limit");
            

        }

    }
}
