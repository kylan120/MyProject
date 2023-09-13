using Microsoft.AspNetCore.Mvc;
using MyProject.Models;

namespace MyProject.Controllers
{
    public class HomeController : Controller
    {
        // This is the controller for index
        public IActionResult Index()
        {
            return View();
        }
        // This is the controller for display
        public IActionResult display(User model)
        {
            return View(model);
        }
    }
}
