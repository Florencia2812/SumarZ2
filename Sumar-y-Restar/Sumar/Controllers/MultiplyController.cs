using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Sumar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MultiplyController : ControllerBase
    {
        [HttpGet]
        [Route("Product")]
        public int Mult(int a, int b)
        {
            return (a * b);
        }
        [HttpPost]
        [Route("Product")]
        public int Mult2([FromHeader] int a, [FromHeader] int b)
        {
            return (a * b);
        }
    }
}
