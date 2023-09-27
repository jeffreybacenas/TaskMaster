using Microsoft.AspNetCore.Mvc;

namespace TaskMaster.Controllers
{
    public class UserControlController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UserControlForm()
        {
            return View();
        }

        public IActionResult Permission() 
        {
            return View();
        }
    }
}
