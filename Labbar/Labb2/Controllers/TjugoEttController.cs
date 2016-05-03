using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Labb2.Models;

namespace Labb2.Controllers
{
    public class TjugoEttController : Controller
    {
        // GET: TjugoEtt
        public ActionResult TjugoEtt()
        {
           return View(new TjugoEttModels());
        }

        [HttpPost]
        public ActionResult TjugoEtt(TjugoEttModels model)
        {
            model.IncreaseActualNumber(1);
            model.ComputerChoice();
            model.IncreaseActualNumber(2);
            ModelState.Remove("ActualNumber");
            ModelState.Remove("CpuTurn");
            return View(model);
        }
    }
}