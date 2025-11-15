using lab_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab_3.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        //public ActionResult Index()
        //{
        //    // HttpRequest base object request
        //    //var username = Request["username"];
        //    //ViewBag.name = username;

        //    return View();
        //}

        /* Form Collection
         * this creates an ambiguity since both Index action method gets HttpGet Request 
         * By default, Index() get HttpGet(1) request
         public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Index(FormCollection fc)
        {
            return View(fc);
        }
        */

        // To get rid off this problem, we can use Annotation, example:
        //[HttpGet]
        //public ActionResult Index()
        //{

        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Index(FormCollection fc)
        //{
        //    var username = fc["username"];
        //    ViewBag.Username = username;
        //    return View();
        //}

        //View name mapping
        //public ActionResult Index(string Username, string Password)
        //{
        //    var uname = Username;

        //    return View();
        //}

        //Model Binding
        public ActionResult Index(Login login)
        {
            if(login.Username == "admin" && login.Password == "1234")
            {
                
            }            
            return View();
        }
    }
}