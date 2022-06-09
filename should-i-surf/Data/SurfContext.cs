using Microsoft.EntityFrameworkCore;
using should_i_surf.Models;

namespace should_i_surf.Data
{
    public class SurfContext : DbContext
    {
        public SurfContext(DbContextOptions<SurfContext> opt) : base(opt)
        {
            
        }

        public DbSet<Forecast> Forecasts { get; set; }
        
    }
}