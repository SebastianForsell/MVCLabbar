using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TwentyOneAjax.Models;

namespace TwentyOneAjax.Controllers
{
    public class TwentyOneAjaxController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult _Game()
        {
            return PartialView(new TwentyOneAjaxModel());
        }
        
        [HttpPost]
        public PartialViewResult _Game(TwentyOneAjaxModel model)
        {
            model.IncreaseActualNumber(1);
            model.ComputerChoice();
            model.IncreaseActualNumber(2);
            ModelState.Remove("ActualNumber");
            ModelState.Remove("CpuTurn");
            return PartialView(model);
        }
    }
}