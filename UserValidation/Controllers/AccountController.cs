using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserValidation.Models;

namespace UserValidation.Controllers
{
    public class AccountController : Controller
    {
        private readonly IHttpContextAccessor _http;
        public AccountController(IHttpContextAccessor http)
        {
            _http = http;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Employee emp) 
        {
            if (ModelState.IsValid)
            {
                ViewBag.message = "Inserted Successfully";
                _http.HttpContext.Session.SetString("username",emp.Ename);
                return RedirectToAction("Index","Home");
            }
            else
            {
                return View(emp);
            }
        }
    }
}
