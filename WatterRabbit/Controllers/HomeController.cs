using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WatterRabbit.Controllers
{
    public class HomeController : Controller
    {
        //added SplashScreen action to show the splash screen when the application starts
        // Displays the Splash Screen created in Task 1.
        // This view is rendered without a layout and contains the video animation.
        public ActionResult SplashScreen()
        {
            return View();
        }

        // Displays the main home page of the application.
        public ActionResult Index()
        {
            return View();
        }

        // Displays the About page, which explains the purpose of the app.
        public ActionResult About()
        {
            // Passes a short message to the view using ViewBag.
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}