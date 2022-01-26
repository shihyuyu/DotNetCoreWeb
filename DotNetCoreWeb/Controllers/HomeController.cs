using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DotNetCoreWeb.Models;
using DotNetCoreWeb.Service;

namespace DotNetCoreWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISingletonService _singletonService;
        private readonly IScopedService _scopedService;
        private readonly ITransientService _transientService;

        public HomeController(ISingletonService singleton, IScopedService scoped, ITransientService transient)
        {
            _singletonService = singleton;
            _scopedService = scoped;
            _transientService = transient;
        }

        public IActionResult Index()
        {
            ViewBag.A = _singletonService.Get<string, string>("uGUID");
            ViewBag.B = _scopedService.Get<string, string>("uGUID");
            ViewBag.C = _transientService.Get<string, string>("uGUID");

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            ViewBag.A = _singletonService.Get<string, string>("uGUID");
            ViewBag.B = _scopedService.Get<string, string>("uGUID");
            ViewBag.C = _transientService.Get<string, string>("uGUID");

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
