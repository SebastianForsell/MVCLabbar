using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TickTackToe.Models;

namespace TickTackToe.Controllers
{
    public class TickTackToeController : Controller
    {
        // GET: TickTackToe
        public ActionResult Index()
        {
            TickTackToeModel m = new TickTackToeModel(); 
            return View(m);
        }
        [HttpPost]
        public ActionResult Index(TickTackToeModel model)
        {
            if (!model.GameOver)
            {
                model.AddNumber();
                model.CheckIfWon();
                ModelState.Clear();
            }
            return View(model);
        }
    }
}