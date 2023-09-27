using Microsoft.AspNetCore.Mvc;

namespace TaskMaster.Controllers
{
    public class SettingController : Controller
    {
        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Preference()
        {
            return View();
        }
    }
}
