using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCoreWeb.BO;
using DotNetCoreWeb.DBContext;
using DotNetCoreWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreWeb.Controllers
{
    public class LoginController : Controller
    {
        public LoginBO bo;
        public LoginController(DAO DAOService)
        {
            bo = new LoginBO(DAOService);
        }

        public IActionResult Index()
        {
            var list = bo.GetList();
            return View(list);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(sysSecurity vo)
        {
            _ = bo.sysSecurityInsert(vo);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(string id)
        {
            if (string.IsNullOrEmpty(id)) { return NotFound(); }

            var obj = bo.GetOne(id);
            return View(obj);
        }
        [HttpPost]
        public IActionResult Edit(sysSecurity vo)
        {
            _ = bo.sysSecurityUpdate(vo);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Delete(string UID)
        {
            if (string.IsNullOrEmpty(UID)) { return NotFound(); }

            _ = bo.sysSecurityDelete(UID);
            return RedirectToAction("Index");
        }
    }
}