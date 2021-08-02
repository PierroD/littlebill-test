using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace LittleBill_test_backend.Helpers
{
    public class WeatherApiHelper
    {
        private static HttpClient apiUrl { get; set; }
        public static HttpClient init()
        {
            apiUrl = new HttpClient(new HttpClientHandler());
            apiUrl.BaseAddress = new Uri("http://api.openweathermap.org/data/2.5/");
            apiUrl.DefaultRequestHeaders.Accept.Clear();
            apiUrl.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return apiUrl;
        }
    }
}
