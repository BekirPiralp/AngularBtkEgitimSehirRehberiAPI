using SehirRehberi.API.Model;

namespace SehirRehberi.API.DTOS
{
    public class CityForDetailDto
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public string? Name { get; set; }
        public List<Photo> Photos { get; set; }
    }
}
