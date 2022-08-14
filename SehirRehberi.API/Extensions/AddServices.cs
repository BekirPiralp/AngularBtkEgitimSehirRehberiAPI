using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using SehirRehberi.API.Helpers;
using System.Text;

namespace SehirRehberi.API.Extensions
{
    public static class AddServices
    {
        public static void MyAdd(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddAutoMapper(typeof(AutoMapperProfiles));

            var key = Encoding.UTF8.GetBytes(configuration.GetSection("AppSettings:Token").Value);
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(
                options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters {
                        ValidateIssuerSigningKey = true,//key kontrolü yapılsın bizim özel key için
                        IssuerSigningKey = new SymmetricSecurityKey(key),
                        ValidateIssuer = false, // herkese açık olduğu için buları bilerek false yapıyoruz
                        ValidateAudience = false
                    };
                }
                );
        }

        public static void AddMiddleWare(this IApplicationBuilder app)
        {
            app.UseAuthentication();
        }
    }
}
