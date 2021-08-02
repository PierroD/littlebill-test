using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LittleBill_test_backend.Models.WeatherModel
{
    public class Wind
    {
        public double speed { get; set; }
        public int deg { get; set; }

        public int gust { get; set; }
    }
}
