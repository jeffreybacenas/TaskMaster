using Microsoft.AspNetCore.Mvc;

namespace TaskMaster.Controllers
{
    public class ActivityLogsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
