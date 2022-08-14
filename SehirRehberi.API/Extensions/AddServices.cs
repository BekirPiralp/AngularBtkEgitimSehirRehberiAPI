using SehirRehberi.API.Helpers;

namespace SehirRehberi.API.Extensions
{
    public static class AddServices
    {
        public static void Add(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(AutoMapperProfiles));
        }
    }
}
