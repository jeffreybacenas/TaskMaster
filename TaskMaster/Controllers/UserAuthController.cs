using Microsoft.AspNetCore.Mvc;

namespace TaskMaster.Controllers
{
    public class UserAuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register() 
        {
            return View();
        }
    }
}
