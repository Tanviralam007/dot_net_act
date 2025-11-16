using lab_4_EF.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab_4_EF.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        UMSEntities db = new UMSEntities();
        public ActionResult Index()
        {
            var student1 = new Student();
            student1.Name = "Jalal";
            student1.Address = "Dhaka, Bangladesh";
            student1.Email = "std@gmail.com";

            db.Students.Add(student1);
            db.SaveChanges();
            return View();
        }
        public ActionResult List()
        {
            var data = db.Students.ToList();
            return View(data);
        }
    }
}