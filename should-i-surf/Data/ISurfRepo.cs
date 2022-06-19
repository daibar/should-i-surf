using System.Collections.Generic;
using should_i_surf.Models;

namespace should_i_surf.Data
{
    public interface ISurfRepo
    {
        bool SaveChanges();
        IEnumerable<Forecast> GetSurfForecasts();
        Forecast GetForecastById(int id);
        void CreateForecast(Forecast frc);
    }
}