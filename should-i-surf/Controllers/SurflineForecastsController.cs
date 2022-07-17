using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace should_i_surf.Controllers
{
    [ApiController]
    [Route("api/surflineforecasts")]
    public class SurflineForecastsController : ControllerBase
    {
        private readonly ILogger<SurflineForecastsController> _logger;

        public SurflineForecastsController(ILogger<SurflineForecastsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<string> Get(string cityName)
        {
            var URL = $"http://api.weatherapi.com/v1/current.json?key=e15c553d3d3d4da19ff21448221707 &q={cityName}&aqi=no";
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(URL);
            return await response.Content.ReadAsStringAsync();
        }

    }
}