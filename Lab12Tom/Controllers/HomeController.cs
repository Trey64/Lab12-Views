using Lab12Tom.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab12Tom.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            Students student = new Students
            {
                Name = "John",
                Age = 18,
                Course = "English",
                Grade = 84

            };

            List<Students> students = new List<Students>() { student };
            students.Add(new Students { Name = "Josephine", Age = 17, Course = "Math", Grade = 92 });
            students.Add(new Students { Name = "Joanna", Age = 18, Course = "Biology", Grade = 90 });
            students.Add(new Students { Name = "Johnny", Age = 20, Course = "History", Grade = 57 });


            return View(students);
        }

        [Route("Register")]
        public ViewResult Register()
        {
            return View();
        }


    }
}
