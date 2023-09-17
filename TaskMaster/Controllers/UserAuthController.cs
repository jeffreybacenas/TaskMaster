using Microsoft.AspNetCore.Mvc;

namespace TaskMaster.Controllers
{
    public class UserAuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
