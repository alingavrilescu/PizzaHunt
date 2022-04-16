using Microsoft.AspNetCore.Mvc;

namespace Pizza_Hunt.Controllers
{
    public class RegistrationController : Controller
    {
        public IActionResult signup()
        {
            return View();
        }

        public IActionResult login()
        {
            return View();
        }
    }
}
