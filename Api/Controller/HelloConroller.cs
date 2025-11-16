using Microsoft.AspNetCore.Mvc;

namespace Api.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloController : ControllerBase  // ← исправлено!
    {
        [HttpGet("hello/{name}")]
        public string GetGreetingByName(string name)
        {
            return $"Привет, {name}";
        }
    }
}
