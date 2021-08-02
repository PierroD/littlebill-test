using LittleBill_test_backend.Models.WeatherModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LittleBill_test_backend.Models.WeatherModel
{
    public class WeatherResult
    {
        public Coordinates coord { get; set; }

        public WeatherResult[] weathers { get; set; }

        [Column("base")]
        public string baseStation {get; set;}

        public Main main { get; set; }
        public int visibility { get; set; }
        public Wind wind { get; set; }

        public Rain rain { get; set; }
        public Rain snow { get; set; }

        public Cloud clouds { get; set; }


        public int dt { get; set; }

        public CountryInformation sys { get; set; }

        public int timezone { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int cod { get; set; }
    }

}
