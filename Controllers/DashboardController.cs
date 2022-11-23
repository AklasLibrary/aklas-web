using Microsoft.AspNetCore.Mvc;

namespace AklasWeb.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
