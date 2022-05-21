using System.Collections.Generic;
using System.Data.Common;
using should_i_surf.Models;

namespace should_i_surf.Data
{
    public class MockSurfRepo : IForecast

    {
        public IEnumerable<Forecast> GetSurfForecasts()
        {
            var forecasts = new List<Forecast>
            {
                new Forecast{Id=0, SwellRating = 10, WeatherRating = 10, Outlook = "Surf's up!!"},
                new Forecast{Id=1, SwellRating = 8, WeatherRating = 10, Outlook = "Send it!"},
                new Forecast{Id=2, SwellRating = 6, WeatherRating = 10, Outlook = "Might as well."}
            };

            return forecasts;
        }

        public Forecast GetForecastById(int id)
        {
            return new Forecast {Id = 0, SwellRating = 10, WeatherRating = 10, Outlook = "Surf's up!"};
        }
    }
}