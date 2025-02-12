using Microsoft.AspNetCore.Mvc;

namespace DirectManagement.UI.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Register()
        {
            if (User.Identity.IsAuthenticated)
                return RedirectToAction("Index", "Dashboard");
            return View();
        }
        public IActionResult Login() => View();

    }
}
