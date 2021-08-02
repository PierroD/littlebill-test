using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LittleBill_test_backend.Requests
{
    public class ResetPasswordRequest
    {
        [Required]
        public string mail { get; set; }
    
    }
}
