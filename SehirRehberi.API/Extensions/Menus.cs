using AutoMapper;
using SehirRehberi.API.Data;

namespace SehirRehberi.API.Extensions
{
    public static class Menus
    {
        public static void TheFoodMenu(this IServiceCollection services)
        {
            services.AddScoped<IAppRepository, AppRepository>();
            services.AddScoped<IAuthRepository,AuthRepository>();
            
        }
    }
}
