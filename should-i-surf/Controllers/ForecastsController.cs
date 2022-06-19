using System.Collections;
using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using should_i_surf.Data;
using should_i_surf.Dtos;
using should_i_surf.Models;

namespace should_i_surf.Controllers
{
    [Route("api/forecasts")]
    [ApiController]
    public class ForecastsController : ControllerBase
    {
        private readonly ISurfRepo _repository;
        private readonly IMapper _mapper;

        public ForecastsController(ISurfRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        
        //GET api/forcasts
        [HttpGet]
        public ActionResult <IEnumerable<ForecastReadDto>> GetAllForecasts()
        {
            var forecastItems = _repository.GetSurfForecasts();

            return Ok(_mapper.Map<IEnumerable<ForecastReadDto>>(forecastItems));

        }

        //GET  api/forecasts/{id}
        [HttpGet("{id}", Name="GetForecastById")]
        public ActionResult <ForecastReadDto> GetForecastById(int id)
        {
            var forecastItem = _repository.GetForecastById(id);
            if (forecastItem != null)
            {
                return Ok(_mapper.Map<ForecastReadDto>(forecastItem));
            }

            return NotFound();
        }
        
        //POST api/forecasts
        [HttpPost]
        public ActionResult <ForecastCreateDto> CreateForecast(ForecastCreateDto forecastCreateDto)
        {
            var forecastModel = _mapper.Map<Forecast>(forecastCreateDto);
            _repository.CreateForecast(forecastModel);
            _repository.SaveChanges();

            var forecastReadDto = _mapper.Map<ForecastReadDto>(forecastModel);

            return CreatedAtRoute(nameof(GetForecastById), new {Id = forecastReadDto.Id}, forecastReadDto);
        }
    }
}