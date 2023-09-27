using Microsoft.AspNetCore.Mvc;

namespace TaskMaster.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProjectForm()
        {
            return View();
        }
    }
}
