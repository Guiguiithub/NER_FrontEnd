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

        // Detail page for new installation
        public IActionResult InstallationDetail(NewInstallationM newInstallation)
        {
            return View(newInstallation);
        }
        [HttpPost]
        public IActionResult InstallationDetailD(NewInstallationM newInstallation)
        {
            return RedirectToAction("InstallationLocation", newInstallation);
        }

        public IActionResult InstallationLocation(NewInstallationM newInstallation)
        {
            return View(newInstallation);
        }
        [HttpPost]
        public IActionResult InstallationLocationD(NewInstallationM newInstallation)
        {
            HttpContext.Session.SetString("PreviousPage", "/Home/InstallationLocation");
            return RedirectToAction("InstallationType", newInstallation);
        }

        public IActionResult InstallationType(NewInstallationM newInstallation)
        {
            return View(newInstallation);
        }

        [HttpPost]
        public IActionResult InstallationTypeD(NewInstallationM newInstallation)
        {
            HttpContext.Session.SetString("PreviousPage", "/Home/InstallationType");
            return RedirectToAction("InstallationOrientation", newInstallation);
        }

        // Orientation page for new installation
        public IActionResult InstallationOrientation(NewInstallationM newInstallation)
        {
            return View(newInstallation);
        }

        [HttpPost]
        public IActionResult InstallationOrientationD(NewInstallationM newInstallation)
        {
            HttpContext.Session.SetString("PreviousPage", "/Home/InstallationOrientation");
            return RedirectToAction("InstallationSurface", newInstallation);
        }

        [HttpPost]
        public IActionResult GoPageOrientation(NewInstallationM newInstallation)
        {
            return RedirectToAction("InstallationOrientation", newInstallation);
        }
        [HttpPost]
        public IActionResult GoPageType(NewInstallationM newInstallation)
        {
            return RedirectToAction("InstallationType", newInstallation);
        }
        [HttpPost]
        public IActionResult GoPageLocation(NewInstallationM newInstallation)
        {
            return RedirectToAction("InstallationLocation", newInstallation);
        }
        [HttpPost]
        public IActionResult GoPageDetail(NewInstallationM newInstallation)
        {
            return RedirectToAction("InstallationDetail", newInstallation);
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}