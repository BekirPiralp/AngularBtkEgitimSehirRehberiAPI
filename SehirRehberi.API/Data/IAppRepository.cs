using SehirRehberi.API.Model;

namespace SehirRehberi.API.Data
{
    public interface IAppRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        bool SaveAll(); //unit of work tasarım kalıbını uygulamak için kattık

        List<City> GetCities();
        List<Photo> GetPhotosByCityId(int cityId);
        City GetCityById(int cityId);
        Photo GetPhotoById(int photoId);
    }
}
