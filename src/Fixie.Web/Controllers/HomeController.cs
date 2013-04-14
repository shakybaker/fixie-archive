using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Web.WebPages.OAuth;

namespace Fixie.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Welcome");
            }
            else
            {
                return View(OAuthWebSecurity.RegisteredClientData);
            }
        }


        public ActionResult Welcome()
        {
            return View(User.Identity);
        }
    }
}
