using RealSurfClub.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealSurfClub.Controllers
{
    public class MyController : Controller
    {

        // GET: My
        public ActionResult Index()
        {
            var my = new MyModel {Name = "Стефания", Age = 17 };
            ViewBag.My = my;
            return View();
        }

        public ActionResult AboutMe()
        {

            var my = new MyModel { Name = "Агафья", Age = 27 };
            return View(my);
        }
    }
}