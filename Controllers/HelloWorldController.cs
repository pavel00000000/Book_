using Microsoft.AspNetCore.Mvc;
using Book;  // Подключение пространства имен, где находится сервис

namespace YourNamespace.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        private readonly INewService _newService;

        // Внедрение зависимости (интерфейса сервиса)
        public HelloWorldController(INewService newService)
        {
            _newService = newService;
        }

        // Эндпоинт, возвращающий строку из сервиса
        [HttpGet("get-message")]
        public IActionResult GetMessage()
        {
            var message = _newService.GetMessage();
            return Ok(message);
        }
    }
}
