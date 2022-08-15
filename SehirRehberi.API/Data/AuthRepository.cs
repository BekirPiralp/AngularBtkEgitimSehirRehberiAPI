using Microsoft.EntityFrameworkCore;
using SehirRehberi.API.Model;

namespace SehirRehberi.API.Data
{
    public class AuthRepository : IAuthRepository
    {
        DataContext _context;

        public AuthRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<User> Login(string userName, string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.UserName == userName);
            if(user == null)
            {
                return null;
            }
            if (!VeriftPasswordHash(password,user.PasswordHash,user.PasswordSalt))
            {
                return null;
            }
            return user;
        }

        private bool VeriftPasswordHash(string password, byte[]? passwordHash, byte[]? passwordSalt)
        {
            bool dönüt=true;
            using(var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i])
                    {
                        dönüt = false;
                        break;
                    }
                }
            }

            return dönüt;
        }

        public async Task<User> Register(User user, string password)
        {
            byte[] passwordHash, passwordSalt;

            CreatePasswordHash(password,out passwordHash,out passwordSalt);

            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();

            return user;
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        public async Task<bool> UserExits(string userName)
        {
            bool dönüt=false;
            if(await _context.Users.AnyAsync(u=>u.UserName == userName))
            {
                dönüt = true;
            }
            return dönüt;
        }
    }
}
