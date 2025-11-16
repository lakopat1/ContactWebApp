using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class TestController : ControllerBase 
{
    //Создаем ендпоинт это обычный метод че это такое интересно 
    [HttpGet("test")]
    public string GetHelloWorldText()
    {
        return "Hello world";
    }

}

