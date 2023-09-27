using Microsoft.AspNetCore.Mvc;

namespace TaskMaster.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MemberForm()
        {
            return View();
        }

    }
}
