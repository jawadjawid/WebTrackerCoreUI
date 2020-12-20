using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebTrackerCoreUI.Models;
using WebTrackerUI.Models;
using QueueApp;
using Azure.Storage.Queues;

namespace WebTrackerCoreUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public ActionResult Tracker()
        {
            ViewBag.Message = "Tracker Page";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> TrackerAsync(TrackerModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    ViewBag.Message = $"Processing your request";

                    QueueApp.Program.Run(model.WebsiteURL, model.EmailAddress);

                    TempData["Message"] = $"Sucuessfuly Tracked {model.WebsiteURL}, we'll send you updates to {model.EmailAddress} as soon as there's any change to the website!";
                    return RedirectToAction("Tracker");
                }
                catch
                {
                    TempData["Message"] = $"Error, please try again later!";
                    return View();
                }
            }
            TempData["Message"] = $"Invalid input!";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
