using DTOLayer.DTOs.AnnouncementDTOs;
using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisnessLayer.ValidutionRole
{
    public class AnnouncementValidator:AbstractValidator<AnnouncementAddDTOs>
    {
        public AnnouncementValidator() 
        {
            //RuleFor(x => x.Title).NotEmpty().WithMessage("Boş keçməyin");
            //RuleFor(x => x.Content).NotEmpty().WithMessage("Boş keçməyin");
            //RuleFor(x => x.Title).MinimumLength(5).WithMessage("Ən az 5 hərfdən İbarət olmalıdır");
            //RuleFor(x => x.Content).MinimumLength(10).WithMessage("Ən az 10 hərfdən İbarət olmalıdır");
            //RuleFor(x => x.Content).MaximumLength(1000).WithMessage("Ən çox 1000 hərfdən ibarət ola bilər");
            //RuleFor(x => x.Title).MaximumLength(50).WithMessage("Ən çox 50 hərfdən ibarət ola bilər");
        }

    }
}
