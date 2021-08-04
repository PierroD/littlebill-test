using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LittleBill_test_frontend_library.Responses.WeatherResponse
{
    public class Rain
    {
        public int all { get; set; }

        [Column("1h")]
        public int onehour { get; set; }
        [Column("3h")]
        public int threehours { get; set; }
    }
}
