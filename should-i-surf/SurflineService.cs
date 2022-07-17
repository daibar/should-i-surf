using System.Net.Http;
using System.Threading.Tasks;

namespace should_i_surf
{
        public interface ISurflineService
        {
            Task<string> Get(string cityName);
        }
        
        public class SurflineService : ISurflineService
        {
            private HttpClient _httpClient;

            public SurflineService(HttpClient httpClient)
            {
                _httpClient = httpClient;
            }

            public async Task<string> Get(string cityName)
            {
                var apiKey = "e15c553d3d3d4da19ff21448221707";

                string APIURL = $"?key={apiKey}&q={cityName}";
                var response = await _httpClient.GetAsync(APIURL);
                return await response.Content.ReadAsStringAsync();
            }

        }
        
 }