using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisnessLayer.ValidutionRole
{
    public class GuideValidator:AbstractValidator<Guide>
    {
        public GuideValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Boş keçməyin");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Boş keçməyin");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Boş keçməyin");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Boş keçməyin");
            RuleFor(x => x.Status).NotEmpty().WithMessage("Boş keçməyin");

        }
    }
}
