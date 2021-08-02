using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LittleBill_test_backend.Helpers
{
    public class AppSettings
    {
        public string Secret { get; set; }
        public string ResetMailSecret { get; set; }
        public string Mail { get; set; }
        public string Password{ get; set; }
    }
}
