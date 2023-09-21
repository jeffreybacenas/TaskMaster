using Microsoft.AspNetCore.Mvc;

namespace TaskMaster.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
