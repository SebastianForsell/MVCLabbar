using PartialViewAjax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartialViewAjax.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Details()
        {
            Student student = new Student()
            {
                StudentID = 1,
                Name = "Ivan",
                Surname = "Prgomet",
                Personnummer = "900615-4892",
                Address = "Gorbatchjevgatan 24",
                Grades = new List<Grade>
                {
                    new Grade {ID = 1, CourseName = "MVC", grade = "A+"},
                    new Grade {ID = 2, CourseName = "HTML5", grade = "B-"}
                }
            };
            Session["Student"] = student;
            return View(student);
        }
    }
}