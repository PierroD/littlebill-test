using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleBill_test_frontend_library.Responses
{ 
    public class LoginResponse
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string token { get; set; }
    }
}
