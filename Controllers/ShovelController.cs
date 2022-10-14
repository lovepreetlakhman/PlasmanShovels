using Microsoft.AspNetCore.Mvc;

namespace PlasmanShovels.Controllers
{
    public class ShovelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
