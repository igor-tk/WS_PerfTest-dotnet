using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WS_PerfTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestsController : ControllerBase
    {
        [HttpGet("get-dt")]
        public string GetDt()
        {
            return DateTime.Now.ToString("O");
        }
    }
}
