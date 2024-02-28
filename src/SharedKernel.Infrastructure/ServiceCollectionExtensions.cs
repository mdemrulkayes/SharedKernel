using Microsoft.Extensions.DependencyInjection;

namespace SharedKernel.Infrastructure;
public static class ServiceCollectionExtensions
{
    public static IServiceCollection RegisterSharedInfrastructure(this IServiceCollection services)
    {
        services.AddTransient<ITimeProvider, TimeProvider>();
        return services;
    }
}
