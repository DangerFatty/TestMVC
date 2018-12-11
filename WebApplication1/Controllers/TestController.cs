using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TestController : Controller
    {
        [HttpGet]
        public ActionResult Test()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Test(Test t)
        {
            double h = t.Height / 100;
            double w = t.Weight;
            t.BMI = w / h / h;

            return View(t);
        }
    }
}