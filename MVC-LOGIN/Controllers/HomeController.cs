using MVC_LOGIN.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_LOGIN.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(RegisterViewModel model)
        {
            if(ModelState.IsValid) {
                Session["user"] = model;
                return RedirectToAction("Index");   
            }
            return View();
        }
        public ActionResult Logout()
        {
            Session.Clear();
            return View();
        }
    }
}