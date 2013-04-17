using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Web.WebPages.OAuth;

namespace Fixie.Web.Controllers
{
    public class PublicController : Controller
    {
        //
        // GET: /Public/

        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
                return RedirectToAction("Welcome", "Home");

            return View(OAuthWebSecurity.RegisteredClientData);
        }

        public PartialViewResult Home()
        {
            return PartialView(OAuthWebSecurity.RegisteredClientData);
        }

        public PartialViewResult About()
        {
            return PartialView(OAuthWebSecurity.RegisteredClientData);
        }

        public PartialViewResult Contact()
        {
            return PartialView(OAuthWebSecurity.RegisteredClientData);
        }

    }
}
