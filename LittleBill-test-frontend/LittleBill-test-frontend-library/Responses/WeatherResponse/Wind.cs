using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LittleBill_test_frontend_library.Responses.WeatherResponse
{
    public class Wind
    {
        public double speed { get; set; }
        public int deg { get; set; }

        public double gust { get; set; }
    }
}
