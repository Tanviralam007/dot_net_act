using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lab_3.Models;

namespace lab_3.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult StudentInfo()
        {
            return View(new Student());
        }

        [HttpPost]
        public ActionResult StudentInfo(Student student)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Student");
            }
            return View(student);
        }
    }
}