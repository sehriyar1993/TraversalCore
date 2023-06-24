using DTOLayer.DTOs.AppUserDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisnessLayer.ValidutionRole
{
    public class AppUserRegistorValidator: AbstractValidator<AppUserRegistorDTOs>
    {
        public AppUserRegistorValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Zəhmət olmasa adınızı qeyd edin");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Zəhmət olmasa soy adınızı qeyd edin");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Zəhmət olmasa istifadəçi adınızı qeyd edin");
            RuleFor(x => x.UserName).MinimumLength(5).WithMessage("Zəhmət olmasa istifadəçi adında ən az 5 simvoldan istifadə edin");
            RuleFor(x => x.UserName).MaximumLength(30).WithMessage("Zəhmət olmasa istifadəçi adında ən çox 30 simvoldan istifadə edin");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Zəhmət olmasa mail ünvanınızı qeyd edin");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Zəhmət olmasa şifrənizi qeyd edin");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Zəhmət olmasa şifrənizi təkrarlayın");
            RuleFor(x => x.Password).Equal(y =>y.ConfirmPassword).WithMessage("Şifrələr uyğun deyil");
        }
    }
}
