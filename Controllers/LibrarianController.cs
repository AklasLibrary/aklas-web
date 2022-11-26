using Microsoft.AspNetCore.Mvc;

namespace AklasWeb.Controllers
{
    public class LibrarianController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
