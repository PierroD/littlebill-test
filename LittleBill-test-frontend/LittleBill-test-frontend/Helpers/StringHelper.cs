using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleBill_test_frontend.Helpers
{
    public class StringHelper
    {
        public static bool isNotNullOrEmpty(string testedString)
        {
            return testedString.Trim().Length > 0 && testedString != null;
        }
    }
}
