using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LittleBill_test_backend.Requests
{
    public class SearchWeatherRequest
    {
        [Required]
        public string cityName { get; set; }
        public string units { get; set; }
        public string lang { get; set; }
    }
}
