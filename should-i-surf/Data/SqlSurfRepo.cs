using System;
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

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public IEnumerable<Forecast> GetSurfForecasts()
        {
            return _context.Forecasts.ToList();
        }

        public Forecast GetForecastById(int id)
        {
            return _context.Forecasts.FirstOrDefault(p => p.Id == id);
        }

        public void CreateForecast(Forecast frc)
        {
            if (frc == null)
            {
                throw new ArgumentNullException(nameof(frc));
            }

            _context.Forecasts.Add(frc);
        }
    }
}