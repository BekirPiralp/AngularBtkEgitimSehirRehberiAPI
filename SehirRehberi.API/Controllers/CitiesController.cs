using AutoMapper;
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
        private IMapper _mapper;
        public CitiesController(IAppRepository repository,IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }

        [HttpGet]
        public ActionResult GetCities()
        {
            var dönen = _repository.GetCities();
            var dönüt = _mapper.Map<List<CityForListDto>>(dönen);
            return Ok(dönüt);
        }
    }
}
