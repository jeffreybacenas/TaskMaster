using Microsoft.AspNetCore.Mvc;

namespace TaskMaster.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Categories()
        {
            return View();
        }

        public IActionResult CreateNew() 
        {
            return View();
        }
    }
}
