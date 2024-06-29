using MediatRPattern.Application.Abstractions;
using MediatRPattern.Infrastructure.Persistence;
using Microsoft.Extensions.DependencyInjection;

namespace MediatRPattern.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddDbContext<IApplicationDBContext, ApplicationDBContext>();
            return services;
        }
    }
}
