using System.Collections.Generic;
using should_i_surf.Models;

namespace should_i_surf.Data
{
    public interface ISurfRepo
    {
        IEnumerable<Forecast> GetSurfForecasts();
        Forecast GetForecastById(int id);
    }
}