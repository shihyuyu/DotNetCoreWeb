using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreWeb.Service;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreWeb.Controllers
{
    public class TestController : Controller
    {
        private readonly ISingletonService _singletonService;
        private readonly IScopedService _scopedService;
        private readonly ITransientService _transientService;

        public TestController(ISingletonService singleton, IScopedService scoped, ITransientService transient)
        {
            _singletonService = singleton;
            _scopedService = scoped;
            _transientService = transient;
        }

        public IActionResult Index()
        {
            try
            {
                ViewBag.A = _singletonService.Get<string, string>("uGUID");
                ViewBag.B = _scopedService.Get<string, string>("uGUID");
                ViewBag.C = _transientService.Get<string, string>("uGUID");
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessgae = ex.ToString();
            }

            return View();
        }
    }
}