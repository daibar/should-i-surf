using System.Collections.Generic;
using System.Linq;
using should_i_surf.Models;

namespace should_i_surf.Data
{
    public class SqlSurfRepo : ISurfRepo
    {
        private readonly SurfContext _context;

        public SqlSurfRepo(SurfContext context)
        {
            _context = context;
        }
        
        public IEnumerable<Forecast> GetSurfForecasts()
        {
            return _context.Forecasts.ToList();
        }

        public Forecast GetForecastById(int id)
        {
            return _context.Forecasts.FirstOrDefault(p => p.Id == id);
        }
    }
}