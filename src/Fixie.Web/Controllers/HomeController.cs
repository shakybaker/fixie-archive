using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Web.WebPages.OAuth;

namespace Fixie.Web.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Welcome()
        {
            return View(User.Identity);
        }
    }
}
