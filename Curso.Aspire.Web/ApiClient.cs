using Curso.Aspire.Web.Components.Pages;

namespace Curso.Aspire.Web
{
    public class ApiClient
    {
        private readonly HttpClient _httpClient;

        public ApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Weather.WeatherForecast[]?> GetWeatherForecastsAsync()
        {
            return await _httpClient.GetFromJsonAsync<Weather.WeatherForecast[]>("weatherForecast");
        }
    }
}
