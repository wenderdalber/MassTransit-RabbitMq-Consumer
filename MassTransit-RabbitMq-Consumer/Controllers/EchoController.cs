using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MassTransit_RabbitMq_Consumer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EchoController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Post()
        {
            return Ok("Ok");
        }
    }
}
