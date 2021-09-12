using Microsoft.Extensions.DependencyInjection;
using Test.BusinessTier.Services;

namespace Test.WebApi.AppStart
{
    public static class CasbinServiceConfig
    {
        public static void InitCasbin(this IServiceCollection services)
        {
            services.AddScoped<ICasbinService, CasbinService>();
        }
    }
}