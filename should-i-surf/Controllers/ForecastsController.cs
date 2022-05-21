using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using should_i_surf.Data;
using should_i_surf.Models;

namespace should_i_surf.Controllers
{
    [Route("api/forecasts")]
    [ApiController]
    public class ForecastsController : ControllerBase
    {
        private readonly MockSurfRepo _repository = new MockSurfRepo();

        //GET api/commands
        [HttpGet]
        public ActionResult<IEnumerable<Forecast>> GetAllForecasts()
        {
            var forecastItems = _repository.GetSurfForecasts();

            return Ok(forecastItems);

        }

        //GET  api/forecasts/{id}
        [HttpGet("{id}")]
        public ActionResult<Forecast> GetForecastById(int id)
        {
            var forecastItem = _repository.GetForecastById(id);
            return Ok(forecastItem);
        }
    }
}