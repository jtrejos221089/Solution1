using Core.Interfaces;
using Infraestructura.Repositories;
using Infraestructura.UnitOfWork;
using Microsoft.Extensions.Options;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace API.Extensions;

public static class ApplicationServiceExtensions
{
    public static void ConfigureCors(this IServiceCollection services)
    {
        services.AddCors(Options =>
        {
            Options.AddPolicy("CorsPolicy", builer =>
            builer.AllowAnyOrigin() //WhithOrigins("https://dominio.com")
            .AllowAnyMethod() //WithMethods("GET", "POST")
            .AllowAnyHeader()); //WhithHeards("accept", "content-type")
        });
    }

    public static void AddApplicationServices(this IServiceCollection services)
    {
        //services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        //services.AddScoped<ICentroMedicoRepository, CentroMedicoRepository>();
        //services.AddScoped<IDatosPreviosRepository, DatosPreviosRepository>();
        //services.AddScoped<IPacienteRepository, PacienteRepository>();
        //services.AddScoped<IProfesionalRepository,ProfesionalRepository>();
        //services.AddScoped<ISintomasRepository, SintomasRepository>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();
    }
}
