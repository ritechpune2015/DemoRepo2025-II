using Microsoft.AspNetCore.Mvc;

namespace DemoApp.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
