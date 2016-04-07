using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModels;

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
            e.salary = 14000;
            EmployeeViewModel evm = new EmployeeViewModel();
            evm.name = e.Firstname + e.lastname;
            evm.salary = e.salary.ToString("C");
            if (e.salary > 15000)
            {
                evm.salary_color = "green";
            }
            else evm.salary_color = "yellow";
            evm.user = "Admin";
            return View("MyView",evm);
        }
    }
}