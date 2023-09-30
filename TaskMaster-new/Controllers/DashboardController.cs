using Microsoft.AspNetCore.Mvc;

namespace TaskMaster_new.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
