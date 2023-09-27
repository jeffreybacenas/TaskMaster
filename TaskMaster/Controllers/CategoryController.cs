using Microsoft.AspNetCore.Mvc;

namespace TaskMaster.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CategoryForm() 
        {
            return View();
        }
    }
}
