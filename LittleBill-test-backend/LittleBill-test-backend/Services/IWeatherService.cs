using LittleBill_test_backend.Helpers;
using LittleBill_test_backend.Models.WeatherModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace LittleBill_test_backend.Services
{
    public interface IWeatherService
    {
        Task<WeatherResult> GetByName(string cityName, string units, string lang);

    }

    public class WeatherService : IWeatherService
    {
   
        public WeatherService() { }

        public async Task<WeatherResult> GetByName(string cityName, string units="standard", string lang="en")
        {
            using (HttpResponseMessage response = await WeatherApiHelper.init().GetAsync($"weather?q={cityName}&units={units}&lang={lang}&appid=13cbdea071a21625d14e24a31fc3b50f"))
            {
                if (response.IsSuccessStatusCode)
                {
                    WeatherResult result = await response.Content.ReadAsAsync<WeatherResult>();
                    return result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
