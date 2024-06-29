using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace MediatRPattern.Application
{
    using MediatR;

    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            return services;
        }
    }
}
