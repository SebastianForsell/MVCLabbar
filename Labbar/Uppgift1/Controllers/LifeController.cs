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
        public ActionResult BrumBrum()
        {
            return View();
        }
        public ActionResult ViewDataTransfer()
        {
            ViewData["Beauty"] = "Det är en häst.";
            return View();
        }
        public ActionResult ViewBagTransfer()
        {
            ViewBag.sleipnir = "Det är en häst som är svart.";
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