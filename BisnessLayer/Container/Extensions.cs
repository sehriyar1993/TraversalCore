using BisnessLayer.Abstarct;
using BisnessLayer.Abstarct.AbstractUow;
using BisnessLayer.Concrete;
using BisnessLayer.Concrete.ConcreteUow;
using BisnessLayer.ValidutionRole;
using DataAcsesslayer.Abstract;
using DataAcsesslayer.Entityframework;
using DataAcsesslayer.UnitOfWork;
using DTOLayer.DTOs.AnnouncementDTOs;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BisnessLayer.Container
{
    public static class Extensions
    {
        public static void ConteinerDependencies(this IServiceCollection services) 
        {
            services.AddScoped<IcommentServices, CommentManager>();
            services.AddScoped<ICommentDal, EFCommentDal>();

            services.AddScoped<IdestinationServices, DestinotionManager>();
            services.AddScoped<IDestinationDal, EFDestinationDal>();

            services.AddScoped<IAppUserServices, AppUserManager>();
            services.AddScoped<IAppUserDAl, EFAppUserDal>();

            services.AddScoped<IReservationServices, ReservationManager>();
            services.AddScoped<IReservationDal, EFReservationDal>();

            services.AddScoped<IContactUsServices, IContactUsManager>();
            services.AddScoped<IContactUsDal, EFContactUsDal>();

            services.AddScoped<iGuideServices, GuideManager>();
            services.AddScoped<IGuideDal, EFGuideDal>();

            services.AddScoped<IAnnouncementServices, AnnouncementManager>();
            services.AddScoped<IAnnouncementDal, EFAnnouncementDal>();

            services.AddScoped<IExcelServices, ExcelManager>();
            services.AddScoped<IPdfReportServices, PdfReportManager>();

            services.AddScoped<IAccountService, AccountManager>();
            services.AddScoped<IAccountDal, EfAccountDal>();

            services.AddScoped<IAboutServices, AboutManager>();
            services.AddScoped<IAboutDal, EFAboutDal>();

            services.AddScoped<ISubAbutServices, SubAboutManager>();
            services.AddScoped<ISubAboutDal, EFSubAboutdal>();

            services.AddScoped<IUowDal, UowDal>();
        }


        public static void  customerValidator(this IServiceCollection services)
        {
            services.AddTransient<IValidator<AnnouncementAddDTOs>, AnnouncementValidator>();

        }
    }
}
