using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using lab_2_task.Models;

namespace lab_2_task.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Portfolio()
        {
            var portfolio = new Models.Portfolio
            {
                UserName = "Tanvir Alam Tanim",
                Id = 22465341,
                CGPA = 3.78,
                Address = "Dhaka, Bangladesh"
            };

            return View(portfolio);
        }

        public ActionResult Education()
        {
            var education = new List<Models.Education>
            {
                new Models.Education
                {
                    Degree = "BSc in Computer Science and Engineering",
                    Institution = "ABC University",
                    YearOfCompletion = 2022
                },
                new Models.Education
                {
                    Degree = "Higher Secondary Certificate",
                    Institution = "XYZ College",
                    YearOfCompletion = 2018
                },
                new Models.Education
                {
                    Degree = "Secondary School Certificate",
                    Institution = "LMN High School",
                    YearOfCompletion = 2016
                }
            };

            return View(education);
        }

        public ActionResult Projects()
        {
            var projects = new List<Models.Projects>
            {
                new Models.Projects
                {
                    ProjectName = "E-commerce Website",
                    Description = "Developed a full-featured e-commerce website using ASP.NET MVC and SQL Server.",
                    TechnologiesUsed = "ASP.NET MVC, C#, SQL Server, HTML, CSS, JavaScript"
                },
                new Models.Projects
                {
                    ProjectName = "Chat Application",
                    Description = "Created a real-time chat application using SignalR and .NET Framework.",
                    TechnologiesUsed = "SignalR, .NET Framework, C#, HTML, CSS, JavaScript"
                },
                new Models.Projects
                {
                    ProjectName = "Portfolio Website",
                    Description = "Designed and developed a personal portfolio website to showcase projects and skills.",
                    TechnologiesUsed = "HTML, CSS, JavaScript, Bootstrap"
                }
            };

            return View(projects);
        }
    }
}