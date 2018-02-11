using LinkShortener.Models;
using LinkShortener.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LinkShortener.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string id)
        {
            if(id != null)
            {
                LinkDatabase db = LinkDatabase.getInstance();
                try
                {
                    string longUrl = db.getLongUrl(id);
                    if (longUrl != null)
                    {
                        return Redirect(longUrl);
                    }
                }
                catch (ArgumentException a)
                {
                    ViewBag.errorLongUrl = "Sorry, couldn't find your url";
                }
            }
            return View();
        }

        [HttpPost]
        public ActionResult StoreLongUrl(Links link)
        {
            if(ModelState.IsValid)
            {
                string longUrl = link.LongUrl;
                LinkDatabase db = LinkDatabase.getInstance();
                string id = db.saveLongURL(longUrl);
                string shortUrl = "http://130.211.114.195/Home/Index/" + id;
                ViewBag.resultLine = "Here is your short Url:";
                ViewBag.result = shortUrl;
                ModelState.Clear();
                return View("Index");
            }

            return View("Index", link);
        }

        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}