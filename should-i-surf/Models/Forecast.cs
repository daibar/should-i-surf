namespace should_i_surf.Models
{
    public class Forecast
    {
        public int Id { get; set; }
        public int SwellRating { get; set; }
        public int WeatherRating { get; set; }
        public string Outlook { get; set; }
    }
}