using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryManagementSystem.Controllers
{
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

}