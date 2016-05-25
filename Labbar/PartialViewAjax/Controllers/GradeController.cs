using PartialViewAjax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartialViewAjax.Controllers
{
    public class GradeController : Controller
    {
        // GET: Grade
        public PartialViewResult _ListForStudent(int studentId)
        {
            List<Grade> grades = ((Student)Session["Student"]).Grades;
            return PartialView(grades);
        }

        public PartialViewResult _Add(int studentId)
        {
            return PartialView(new Grade() { ID = studentId });
        }

        [HttpPost]
        public ActionResult _Add(Grade model)
        {
            ((Student)Session["Student"]).Grades.Add(model);
            return RedirectToAction(actionName: "_ListForStudent", routeValues: new { studentId = model.ID });
        }
    }
}