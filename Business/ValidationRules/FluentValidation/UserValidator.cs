using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.FirstName).NotEmpty();
            RuleFor(u => u.LastName).NotEmpty();
            RuleFor(u => u.FirstName).MinimumLength(3);
            RuleFor(u => u.LastName).MinimumLength(2);
            RuleFor(u => u.Password).NotNull();
            RuleFor(u => u.Email).NotNull();
            RuleFor(u => u.Email).Must(ContainsCom).WithMessage("Check .com symbol!!");
            
        }

        private bool ContainsCom(string arg)
        {
            return arg.Contains(".com");
        }
    }
}
