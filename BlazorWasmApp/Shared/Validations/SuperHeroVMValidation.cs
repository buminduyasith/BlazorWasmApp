using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWasmApp.Shared.Validations
{
    public class SuperHeroVMValidation: AbstractValidator<SuperHeroVM>
    {
        public SuperHeroVMValidation()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Name is Required");
        }
    }
}
