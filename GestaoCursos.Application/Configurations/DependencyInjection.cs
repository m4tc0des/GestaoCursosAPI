using FluentValidation;
using FluentValidation.AspNetCore;
using GestaoCursos.Application.Dtos.Requests;
using GestaoCursos.Application.Interfaces;
using GestaoCursos.Application.Services;
using Mapster;
using MapsterMapper;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace GestaoCursos.Application.Configurations;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        var config = TypeAdapterConfig.GlobalSettings;
        services.AddSingleton(config);
        services.AddScoped<IMapper, ServiceMapper>();
        TypeAdapterConfig<CreateCourseRequest, Course>
        .NewConfig()
        .ConstructUsing(src => new Course(src.Title, src.Description, src.DurationInHours, src.Price));
        services.AddScoped<ICourseService, CourseService>();

        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        services.AddFluentValidationAutoValidation();

        return services;
    }
}