using Microsoft.AspNetCore.Mvc;

namespace AklasWeb.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View("Librarian");
        }

        public IActionResult Librarian()
        {
            return View();
        }

        public IActionResult Admin()
        {
            return View();
        }
    }
}
