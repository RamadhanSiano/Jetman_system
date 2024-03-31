using Microsoft.AspNetCore.Mvc;

namespace Jetmanthings.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LoginAdmin()
        {
            return View();
        }
    }
}
