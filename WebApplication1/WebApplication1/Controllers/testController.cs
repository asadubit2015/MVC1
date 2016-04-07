using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
            return View("MyView");
        }
    }
}