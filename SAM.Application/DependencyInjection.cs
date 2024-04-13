using Microsoft.Extensions.DependencyInjection;
using SAM.Application.Services;

namespace SAM.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            return services;
        }
    }
    
}