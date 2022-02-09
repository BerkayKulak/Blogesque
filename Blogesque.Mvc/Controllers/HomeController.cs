using Microsoft.AspNetCore.Mvc;

namespace Blogesque.Mvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
