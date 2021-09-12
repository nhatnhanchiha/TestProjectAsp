
/////////////////////////////////////////////////////////////////
//
//              AUTO-GENERATED
//
/////////////////////////////////////////////////////////////////

using Test.DataTier.Models;
using Microsoft.Extensions.DependencyInjection;
using Test.BusinessTier.Generations.Services;
using Test.BusinessTier.Generations.Repositories;
using Microsoft.EntityFrameworkCore;
using Test.DataTier.BaseConnect;
namespace Test.BusinessTier.Generations.DependencyInjection
{
    public static class DependencyInjectionResolverGen
    {
        public static void InitializerDI(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<DbContext, learning_gormContext>();
        
            services.AddScoped<ISysAuthorityService, SysAuthorityService>();
            services.AddScoped<ISysAuthorityRepository, SysAuthorityRepository>();
        
            services.AddScoped<ISysBookService, SysBookService>();
            services.AddScoped<ISysBookRepository, SysBookRepository>();
        
            services.AddScoped<ISysLockJwtService, SysLockJwtService>();
            services.AddScoped<ISysLockJwtRepository, SysLockJwtRepository>();
        
            services.AddScoped<ISysUserService, SysUserService>();
            services.AddScoped<ISysUserRepository, SysUserRepository>();
        
            services.AddScoped<ISysUserAuthorityService, SysUserAuthorityService>();
            services.AddScoped<ISysUserAuthorityRepository, SysUserAuthorityRepository>();
        }
    }
}
