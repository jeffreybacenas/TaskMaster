using Microsoft.AspNetCore.Mvc;

namespace TaskMaster.Controllers
{
    public class TaskController : Controller
    {
        public IActionResult Tasks()
        {
            return View();
        }

        public IActionResult TaskForm()
        {
            return View();
        }
    }
}
