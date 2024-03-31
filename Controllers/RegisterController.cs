using Microsoft.AspNetCore.Mvc;

namespace Jetmanthings.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult RegisterAdmin()
        {
            return View();
        }
    }
}
