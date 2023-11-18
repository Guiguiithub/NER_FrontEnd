using Microsoft.AspNetCore.Mvc;
using MVC_Client.Models;
using MVC_Client.Services;
using System.Diagnostics;

namespace MVC_Client.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly INerServices _nerServices;

        public HomeController(ILogger<HomeController> logger, INerServices nerServices)
        {
            _logger = logger;
            _nerServices = nerServices;
        }

        public IActionResult Home()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

        public IActionResult InstallationType(NewInstallationM newInstallation)
        {
            return View(newInstallation);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public ActionResult InstallationLocation(NewInstallationM newInstallation)
        {
            return View(newInstallation);
        }

        // Detail page for new installation
        public ActionResult InstallationDetail()
        {
            return View();
        }

        // Orientation page for new installation
        public ActionResult InstallationOrientation(NewInstallationM newInstallation)
        {
            return View(newInstallation);
        }

        [HttpPost]
        public async Task<IActionResult> Create(NewInstallationM newInstallation)
        {
            if (ModelState.IsValid)
            {
                await _nerServices.PostInstallation(newInstallation);
                return RedirectToAction("Details");
            }
            return View(newInstallation);
        }
    }
}