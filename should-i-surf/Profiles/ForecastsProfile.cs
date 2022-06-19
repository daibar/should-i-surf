using AutoMapper;
using should_i_surf.Dtos;
using should_i_surf.Models;

namespace should_i_surf.Profiles
{
    public class ForecastsProfile : Profile
    {
        public ForecastsProfile()
        {
            CreateMap<Forecast, ForecastReadDto>();
        }
        
    }
}