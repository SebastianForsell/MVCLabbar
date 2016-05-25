using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialViewAjax.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Personnummer { get; set; }
        public string Address { get; set; }
        public List<Grade> Grades { get; set; }
    }
}
