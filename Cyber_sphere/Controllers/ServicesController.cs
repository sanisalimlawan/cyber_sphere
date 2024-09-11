using Microsoft.AspNetCore.Mvc;

namespace Cyber_sphere.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
