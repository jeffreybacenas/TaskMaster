using Microsoft.AspNetCore.Mvc;

namespace TaskMaster.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult Members()
        {
            return View();
        }

        public IActionResult MemberForm()
        {
            return View();
        }

    }
}
