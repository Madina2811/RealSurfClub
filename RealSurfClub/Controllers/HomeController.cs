using RealSurfClub.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealSurfClub.Controllers
{
    public class HomeController : Controller
    {
        SurfDbContext dbContext = new SurfDbContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult BordSelling()
        {
            ViewBag.Message = "Surfing-club-sells-boards";
            ViewBag.Ads = "Покупайте наши доски";

            ViewBag.Prices = new[] { 100, 120, 140, 99 };

            var user = dbContext.Users.FirstOrDefault();

            ViewBag.Seller = user;




            return View();
        }
    }
}