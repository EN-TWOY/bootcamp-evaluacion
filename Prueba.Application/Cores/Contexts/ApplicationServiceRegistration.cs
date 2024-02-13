using System.Reflection;
using Microsoft.Extensions.DependencyInjection;


namespace Practica.Application.Cores.Contexts
{
    public static class ApplicationServiceRegistration
	{
		public static IServiceCollection AddApplicationService(this IServiceCollection services)
		{
            // Automapper
            //services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
		}

    }
}

