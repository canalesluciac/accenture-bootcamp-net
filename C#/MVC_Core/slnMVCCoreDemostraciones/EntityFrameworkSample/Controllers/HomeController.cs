using Microsoft.AspNetCore.Mvc;

namespace EntityFrameworkSample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}