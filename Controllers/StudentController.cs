using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryManagementSystem.Controllers
{
    public class StudentController : Controller
    {
        // Student
        public ActionResult StudentList()
        {
            return View();
        }
        // add student
        public ActionResult AddStudent()
        {
            return View();
        }
        // student details
        public ActionResult StudentDetails()
        {
            return View();
        }
    }

}