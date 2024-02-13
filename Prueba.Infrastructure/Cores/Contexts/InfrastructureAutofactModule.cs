using Autofac;
using System.Reflection;

namespace Prueba.Infrastructure.Cores.Contexts
{
	public class InfrastructureAutofactModule: Autofac.Module
	{
        protected override void Load(ContainerBuilder builder)
        {
            base.Load(builder);

            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
        }
    }
}

