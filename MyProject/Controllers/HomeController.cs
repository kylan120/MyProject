using Microsoft.AspNetCore.Mvc;

namespace MyProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Dispaly(User model)
        {
            return View(model);
        }
    }
}
