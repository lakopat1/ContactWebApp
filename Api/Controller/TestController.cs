using Microsoft.AspNetCore.Mvc;

namespace Api.Controller
{
    public class TestController : Basecontroller

    {
        [HttpGet("test")]
        public string GetHelloWorldText()
        {
            return "Hello world";
        }
    }
}

