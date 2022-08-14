namespace SehirRehberi.API.Model
{
    public class User
    {
        public User()
        {
            this.Cities = new List<City>();
        }

        public int Id { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string UserName { get; set; }

        public List<City> Cities { get; set; }
    }
}
