using Microsoft.AspNetCore.Http;

namespace SehirRehberi.API.DTOS
{
    public class PhotoForCreationDto
    {
        public PhotoForCreationDto()
        {
            DateAdded = DateTime.Now;
        }
        public IFormFile File { get; set; }
        public DateTime DateAdded { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string PublicId { get; set; }
    }
}
