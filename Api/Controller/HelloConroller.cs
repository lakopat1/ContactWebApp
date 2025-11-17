using Microsoft.AspNetCore.Mvc;

namespace Api.Controller
{
    public class HelloController : Basecontroller
    {
        [HttpGet("hello/{name}")]
        public string GetGreetingByName(string name)
        {
            return $"Привет, {name}";
        }
    }
}
