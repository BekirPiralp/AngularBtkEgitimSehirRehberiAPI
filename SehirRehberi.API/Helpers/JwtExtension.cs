namespace SehirRehberi.API.Helpers
{
    public static class JwtExtension
    {
        //Varsayılanda sistem bilgileride gittiği için kendimiz burada özelleştirme yapıyoruz
        public static void AddApplicationError(this HttpResponse response,string message)
        {
            response.Headers.Add("Application-Error",message);
            response.Headers.Add("Access-Control-Allow-Origin", "*"); //Tüm herkes başvura bilsin ve bunu görsün
            response.Headers.Add("Access-control-Expose-Header", "Application-Error");//Yukarıda yazdığımız Application-error mutlaka gönderilmesini istiyoruz
        }
    }
}
