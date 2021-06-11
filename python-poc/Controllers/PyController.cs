using Microsoft.AspNetCore.Mvc;

namespace python_poc.Controllers
{
    [ApiController]
    [Route("py")]
    public class PyController : Controller
    {
        [HttpGet]
        public string Get()
        {
            return "hello?";
        }
    }
}
