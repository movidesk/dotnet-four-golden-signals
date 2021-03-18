using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FourGoldenSignals.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LatencyController : ControllerBase
    {
        private readonly ILogger<LatencyController> _logger;

        public LatencyController(ILogger<LatencyController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public int Get()
        {
            var rng = new Random();
            var nr = rng.Next(0, 100);
            System.Threading.Thread.Sleep(nr);
            return nr;
        }

        [HttpGet]
        [Route("witherror")]
        public int GetWithErrors() 
        {
            var rng = new Random();
            var nr = rng.Next(0, 1000);
            System.Threading.Thread.Sleep(nr);

            if (nr % 50 == 0) {
                throw new Exception();
            }

            return nr;
        }
    }
}
