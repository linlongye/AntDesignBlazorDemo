using AntDesignBlazor.Servers.ServiceImplementation;
using AntDesignBlazor.Servers.ServiceInterfaces;
using Microsoft.Extensions.DependencyInjection;

namespace AntDesignBlazor.Servers.ServiceExtensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<INavigationRepository, NavigationRepository>();
            return services;
        }
    }
}