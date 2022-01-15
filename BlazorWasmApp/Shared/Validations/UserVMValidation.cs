using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWasmApp.Shared.Validations
{
    public  class UserVMValidation: AbstractValidator<UserVm>
    {
        public UserVMValidation()
        {
            RuleFor(p => p.UserName).NotEmpty().WithMessage("user Name is Required");
            RuleFor(p => p.FName).NotEmpty().WithMessage("First name is Required");
            RuleFor(p => p.PhoneNumber)
                .NotEmpty().WithMessage("Name is Required")
                .Length(10).WithMessage("should 10 characters");
        }
    }
}
