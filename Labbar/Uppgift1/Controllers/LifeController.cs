using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Uppgift1.Controllers
{
    public class LifeController : Controller
    {
        // GET: Life
        public ActionResult SuperMario(int? id)
        {
            if (id != null)
            {
                ViewBag.GetHelp = "is using Microsoft.SharePoint :)";
            }
            return View();
        }
        public ActionResult Health()
        {
            return View();
        }
        public ActionResult Live()
        {
            return View();
        }
    }
}