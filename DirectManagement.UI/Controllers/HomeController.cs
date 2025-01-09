using DirectManagement.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DirectManagement.UI.Controllers
{
    public class HomeController : Controller
    {
        [Route("PageNotFound")]
        public IActionResult PageNotFound() => View();
    }
}
