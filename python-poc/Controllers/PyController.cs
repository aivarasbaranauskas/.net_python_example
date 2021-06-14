using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace python_poc.Controllers
{
    [ApiController]
    [Route("py")]
    public class PyController : Controller
    {
        private readonly IPyWrap _py;

        public PyController(IPyWrap py)
        {
            _py = py;
        }

        [HttpGet]
        public string Get()
        {
            return _py.multiply(
                new List<float> { 1, 2, 3 },
                new List<float> { 6, 5, 4 }
                );
        }
    }
}
