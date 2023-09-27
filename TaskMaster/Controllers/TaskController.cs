using Microsoft.AspNetCore.Mvc;

namespace TaskMaster.Controllers
{
    public class TaskController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TaskForm()
        {
            return View();
        }
    }
}
