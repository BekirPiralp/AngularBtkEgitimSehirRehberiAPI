namespace SehirRehberi.API.Extensions
{
    public static class CorsSettings
    {
        public static void CorsEnable(this WebApplication app, IServiceCollection services)
        {
            services.AddCors();
            app.UseCors(x=>x.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
        }
    }
}
