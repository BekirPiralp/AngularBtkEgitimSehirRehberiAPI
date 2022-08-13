using SehirRehberi.API.Data;
using Microsoft.EntityFrameworkCore;


namespace SehirRehberi.API.Extensions
{
    public static class InjectSqlServer
    {
        public static void AddSql(this IServiceCollection services, WebApplicationBuilder builder)
        {
            services.AddDbContext<DataContext>(
                x =>x.UseSqlServer(
                     builder.Configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
