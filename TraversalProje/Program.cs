using BisnessLayer.Container;
using DataAcsesslayer.Concrete;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using EntityLayer.Concrete;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc.Razor;
using TraversalCoreProje.CQRS.Handlers.DestinationHandlers;
using TraversalProje.CQRS.Commands.DestinationCommands;
using TraversalProje.CQRS.Handlers.DestinationHandler;
using TraversalProje.Models;


internal class Program
{
    [Obsolete]
    private static void Main(string[] args)
    {
        Configure(new LoggerFactory());
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddScoped<GetAllDestinationQueryHandler>();
        builder.Services.AddScoped<GetDestinationByIDQueryHandler>();
        builder.Services.AddScoped<CreateDestinationCommandHandler>();
        builder.Services.AddScoped<RemoveDestinationCommandHandler>();
        builder.Services.AddScoped<UpdateDestinationCommandHandler>();

        builder.Services.AddMediatR(typeof(Program));
        builder.Services.AddLogging(x =>
        {
            x.ClearProviders();
            x.SetMinimumLevel(LogLevel.Debug);
            x.AddDebug();
        });
        // Add services to the container.
        builder.Services.AddDbContext<Context>();
        builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>().AddErrorDescriber<CustomIdentityValidator>().AddTokenProvider<DataProtectorTokenProvider<AppUser>>(TokenOptions.DefaultProvider).AddEntityFrameworkStores<Context>();
        builder.Services.AddHttpClient();
        builder.Services.AddControllersWithViews();
        builder.Services.ConteinerDependencies();
        builder.Services.AddAutoMapper(typeof(Program));
        builder.Services.customerValidator();
        builder.Services.AddControllersWithViews().AddFluentValidation();
        builder.Services.AddMvc(config =>
        {
            var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
            config.Filters.Add(new AuthorizeFilter(policy));

        });
        builder.Services.AddLocalization(opt =>
        {
            opt.ResourcesPath = "Resources";
        });

        builder.Services.AddMvc().AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix).AddDataAnnotationsLocalization();

        builder.Services.ConfigureApplicationCookie(options =>
        {
            options.LoginPath = "/LogInController1/SignIn/";
        });
        builder.Services.AddMvc();
        //builder.Services.AddSqlServer

        var app = builder.Build();
        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }
        app.UseStatusCodePagesWithReExecute("/ErrorPage/Error404", "?code={0}");
        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseAuthentication();
        app.UseRouting();

        app.UseAuthorization();
        var suppertedCultures = new[] {"az", "en", "tr" };
        var localizationOptions = new RequestLocalizationOptions().SetDefaultCulture(suppertedCultures[1]).AddSupportedCultures(suppertedCultures).AddSupportedUICultures(suppertedCultures);
        app.UseRequestLocalization(localizationOptions);
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
              name: "areas",
              pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
            );
        });
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
              name: "areas",
              pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
            );
        });

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Default}/{action=Index}/{id?}");

        app.Run();
    }
    public static void Configure(ILoggerFactory loggerfactory)
    {
        var path = Directory.GetCurrentDirectory();
        //loggerfactory.AddFile($"{path}\\Logs\\Log1.txt");
    }
}