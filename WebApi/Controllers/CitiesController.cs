
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NetCoreAngular_Project.DTO;

namespace NetCoreAngular_Project.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class CitiesController:ControllerBase
    {
        private readonly IAppRepository _appRepository;
        private readonly IMapper _mapper;
        public CitiesController(IAppRepository appRepository,IMapper mapper)
        {
            _appRepository = appRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var cities = _appRepository.GetCities();
            var citiesToReturn = _mapper.Map<List<CityForListDto>>(cities);
            return Ok(citiesToReturn);
        }

        [HttpPost]
        [Route("add")]
        public ActionResult Add([FromBody]City city){
            _appRepository.Add(city);
            _appRepository.SaveAll();
            return Ok(city);
        }

        [HttpGet]
        [Route("detail")]
        public ActionResult GetCitiesById(int id){
            var city = _appRepository.GetCity(id);
            var cityToReturn = _mapper.Map<CityForDetailDto>(city);
            return Ok(cityToReturn);
        }

        [HttpGet]
        [Route("Photos")]
        public ActionResult GetPhotosByCity(int id){
            var photos = _appRepository.GetPhotosByCity(id);
            return Ok(photos);
        }
    }
}