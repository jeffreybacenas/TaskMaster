using Microsoft.AspNetCore.Mvc;

namespace TaskMaster.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
