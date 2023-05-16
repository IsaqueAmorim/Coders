using Microsoft.AspNetCore.Mvc;

namespace CRUD.API.Controllers
{

    [ApiController]
    [Route("/")]
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var arquivo = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "index.html");
            return PhysicalFile(arquivo, "text/html");
        }
    }
}
