using lab_4_lab_curd.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab_4_lab_curd.Controllers
{
    public class StudentController : Controller
    {
        // Database Obj
        public readonly StudentPortalEntities db = new StudentPortalEntities();

        [HttpGet]
        public ActionResult Create()
        {
            return View(new Student());
        }

        [HttpPost]
        public ActionResult Create(Student student)
        {
            db.Students.Add(student);
            db.SaveChanges();
            TempData["Msg"] = "Student " + student.Name + " has been created";
            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var data = db.Students.Find(id);
            return View(data);
        }

        [HttpPost]
        public ActionResult Edit(Student student)
        {
            var StudentObjById = db.Students.Find(student.Id);
            StudentObjById.Name = student.Name;
            StudentObjById.Email = student.Email;
            StudentObjById.Gender = student.Gender;
            db.SaveChanges();

            TempData["Msg"] = "Data has been updated!";

            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var data = db.Students.Find(id);
            return View(data);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {

            var student = db.Students.Find(id);
            
            if(student != null)
            {
                db.Students.Remove(student);
                db.SaveChanges();
            }

            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult List()
        {
            var data = db.Students.ToList();
            return View(data);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var data = db.Students.Find(id);
            return View(data);
        }
    }
}