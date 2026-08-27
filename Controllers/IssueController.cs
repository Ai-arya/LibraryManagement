using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryManagementSystem.Controllers
{
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