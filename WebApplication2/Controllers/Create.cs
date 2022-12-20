using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class Create : Controller
    {
        // GET: Create
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Crewate()
        {
            ViewBag.UserName = "Allen Kou";
            return View();
        }
    }
}