using Microsoft.AspNetCore.Mvc;
using MVC_Client.Models;
using System.Diagnostics;

namespace MVC_Client.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Home()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

        public IActionResult InstallationType()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ActionResult Location()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Location(LocationM location)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Home", "Home");
            }
            return View(location);
        }

        // Detail page for new installation
        public ActionResult InstallationDetail()
        {
            return View();
        }

        // Orientation page for new installation
        public ActionResult InstallationOrientation()
        {
            return View();
        }
    }
}