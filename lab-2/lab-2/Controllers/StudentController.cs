using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lab_2.Models;

namespace lab_2.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            Student[] students = new Student[10];
            for (int i = 1; i <= 10; i++)
            {
                students[i - 1] = new Student()
                {
                    Id = i,
                    Name = "student" + i,
                    Cgpa = 0
                };
            }
            return View(students);
        }

        public ActionResult Details()
        {
            //var c = 10;
            //c.djujed = 20; -- error
            //dynamic b = 20;
            //b.deje = 20; -- no error

            //ViewBag -- dynamic object it has some properties, take decesion within runtime
            //ViewBag.Name = "Hasin";
            //ViewBag.Id = 123;
            //ViewBag.Cgpa = 2.34;

            //ViewData -- same as ViewBag

            // model binding
            var s1 = new Student();

            s1.Name = "Hasin";
            s1.Id = 222;
            s1.Cgpa = 2.22f;


            return View(s1);
        }
    }
}