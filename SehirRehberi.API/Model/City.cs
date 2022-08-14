namespace SehirRehberi.API.Model
{
    public class City
    {
        public City()
        {
            this.Photos = new List<Photo>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }

        public List<Photo> Photos{ get; set; }
        public User User { get; set; }
    }
}
