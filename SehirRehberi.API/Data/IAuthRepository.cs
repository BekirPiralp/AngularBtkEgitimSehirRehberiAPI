using SehirRehberi.API.Model;

namespace SehirRehberi.API.Data
{
    public interface IAuthRepository
    {
        Task<User> Register(User user,string password);
        Task<User> Login(string userName, string password);
        Task<User> UserExits(string userName);
    }
}
