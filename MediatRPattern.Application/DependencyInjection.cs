using Microsoft.Extensions.DependencyInjection;

namespace MediatRPattern.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            return services;
        }

        public static IServiceCollection AddApplicationMediatR(this IServiceCollection services, Action<MediatRServiceConfiguration> action)
        {
            services.AddMediatR(action);
            return services;
        }
    }
}
