using Microsoft.AspNetCore.Mvc;

namespace AspNetExample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}