using LittleBill_test_backend.Models.WeatherModel;
using LittleBill_test_backend.Requests;
using LittleBill_test_backend.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LittleBill_test_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherController : ControllerBase
    {
        private IWeatherService _weatherService;

        public WeatherController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [Authorize]
        [HttpPost]
        public IActionResult GetByName(SearchWeatherRequest request)
        {
           return Ok(_weatherService.GetByName(request.cityName, request.units, request.lang).Result);
        }
    }
}
