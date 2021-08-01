using LittleBill_test_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LittleBill_test_backend.Helpers
{
    public class ContextHelper
    {

        private static LittleBillDbContext _context = null;

        public static LittleBillDbContext context
        {
            get
            {
                return (_context) ?? (_context = new LittleBillDbContext());
            }
        }
    }
}
