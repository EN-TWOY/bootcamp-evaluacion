using System.Reflection;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;


namespace Practica.Application.Cores.Contexts
{
    public static class ApplicationServiceRegistration
	{
		public static IServiceCollection AddApplicationService(this IServiceCollection services)
		{
            // Automapper
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            // services.AddFluentValidationAutoValidation().AddFluentValidationClientsideAdapters();

            return services;
		}

    }
}

