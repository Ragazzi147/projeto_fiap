using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NoticiasController : ControllerBase
    {       

        private readonly ILogger<NoticiasController> _logger;

        public NoticiasController(ILogger<NoticiasController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("teste");
        }
    }
}