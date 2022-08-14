using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SehirRehberi.API.Data;
using SehirRehberi.API.DTOS;
using SehirRehberi.API.Model;

namespace SehirRehberi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private IAppRepository _repository;
        private IMapper _mapper;
        public CitiesController(IAppRepository repository, IMapper mapper)
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

        [HttpPost]
        [Route("Add")]
        public ActionResult Add([FromBody] City city)
        {
            _repository.Add(city);
            _repository.SaveAll();
            return Ok(city);
        }

        [HttpGet("{id}")]
        public ActionResult GetCityById(int id)
        {
            var dönen = _repository.GetCityById(cityId:id);
            var dönüt = _mapper.Map<CityForDetailDto>(dönen);
            return Ok(dönüt);
        }
    }
}
