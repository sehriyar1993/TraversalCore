using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisnessLayer.ValidutionRole
{
    public class AboutValidator:AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Haqqında qismini boş keçməyin");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("Boş keçməyin");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("Boş keçməyin");
            RuleFor(x => x.Description).MaximumLength(1550).WithMessage("Boş keçməyin");

        }
    }
}
