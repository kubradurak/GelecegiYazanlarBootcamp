using FormNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormNetCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
        public IActionResult Enroll()
        {
            return View();
        }
       [HttpPost]
        public IActionResult Enroll(Student student)
        {
            if (ModelState.IsValid)
            {
                EnrolledStudents.Add(student);
                return View("EnrollDone", student);
            }
            return View();
        }
        public IActionResult EnrolledStudentList()
        {
                
            return View(EnrolledStudents.enrolledStudents);
        }

    }
}
