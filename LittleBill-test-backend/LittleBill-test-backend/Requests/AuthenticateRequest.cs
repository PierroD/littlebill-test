using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LittleBill_test_backend.Requests
{
    public class AuthenticateRequest
    {
        [Required]
        public string Name { get; set; }


        [Required]
        public string Password { get; set; }
    }
}
