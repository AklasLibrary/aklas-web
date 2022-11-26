using Microsoft.AspNetCore.Mvc;

namespace AklasWeb.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
