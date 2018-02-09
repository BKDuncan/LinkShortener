using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LinkShortener.Controllers
{
    public class HomeController : Controller
    {
        /* 
         * Called by onClick method of the Shorten Link Button
         * Redirects the user to google webpage
         */
         
        public ActionResult OnSubmitLink(string longLink)
        {
            return Redirect("https://www.google.com");
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}