using DTOLayer.DTOs.ContactDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisnessLayer.ValidutionRole.ContactUs
{
    public class SendContactUsValidator : AbstractValidator<SendMessageDto>
    {
        public SendContactUsValidator()
        {
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail  boş qoyula bilməz");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Başlıq boş qoyula bilməz");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad boş qoyula bilməz");
            RuleFor(x => x.MessageBody).NotEmpty().WithMessage("Mesaj boş qoyula bilməz");
            RuleFor(x => x.Subject).MinimumLength(5).WithMessage("Başlıq ən az 5 hərfdən ibarət olmadlıdır");
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("Başlıq ən çox 100 hərfdən ibarət olmadlıdır");
            
        }
    }
}
