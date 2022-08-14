using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SehirRehberi.API.Data;
using SehirRehberi.API.DTOS;

namespace SehirRehberi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private IAppRepository _repository;
        public CitiesController(IAppRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult GetCities()
        {
            var dönüt = _repository.GetCities().Select(
                c => new CityForListDto
                {
                    Description = c.Description,
                    Name = c.Name,
                    Id = c.Id,
                    PhotoUrl = c.Photos.FirstOrDefault(p => p.IsMain == true)
                                .Url
                }
                ).ToList();
            return Ok(dönüt);
        }
    }
}
