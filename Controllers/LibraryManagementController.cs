using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryManagementSystem.Controllers
{
    public class LibraryManagementController : Controller
    {
        //LibraryManagement
        public ActionResult Index()
        {
            return View();
        }
    }

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

    public class BookController : Controller
    {
        // book list
        public ActionResult BookList()
        {
            return View();
        }

        // add book
        public ActionResult AddBook()
        {
            return View();
        }

        // book details
        public ActionResult BookDetails()
        {
            return View();
        }

        // return book
        public ActionResult ReturnBook()
        {
            return View();
        }
    }

    public class IssueController : Controller
    {
        // issue book form
        public ActionResult IssueBookForm()
        {
            return View();
        }

        // issued book list
        public ActionResult IssuedBookList()
        {
            return View();
        }

        // issue history
        public ActionResult IssueHistory()
        {
            return View();
        }
    }
 

}