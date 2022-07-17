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
        private readonly ISurflineService _surflineService;

        public SurflineForecastsController(ILogger<SurflineForecastsController> logger, ISurflineService surflineService)
        {
            _logger = logger;
            _surflineService = surflineService;
        }

        [HttpGet]
        public async Task<string> Get(string cityName)
        {
            return await _surflineService.Get(cityName);
        }

    }
}