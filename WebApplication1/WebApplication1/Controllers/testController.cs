using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class testController : Controller
    {
        // GET: test
        public string getstring()
        {
            return "University Of karachi";
        }
        public ActionResult getview()
        {
            Employee e = new Employee();
            e.Firstname = "Asad";
            e.lastname = "Hussain";
            e.salary = 20000;
            ViewData["Employee"] = e;
            return View("MyView");
        }
    }
}