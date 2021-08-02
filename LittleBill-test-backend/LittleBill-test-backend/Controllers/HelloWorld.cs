using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LittleBill_test_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorld : Controller
    {
        public IActionResult Index()
        {
            return Ok("Hello World");
        }
    }
}
