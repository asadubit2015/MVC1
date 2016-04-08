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
int y=0;
        // GET: test
        public string getstring()
        {
            return "University Of karachi";
        }
        public ActionResult getview()
        {
            EmployeeListViewModel elvm = new EmployeeListViewModel();
            EmployeeBusinessLayer sbl = new EmployeeBusinessLayer();
            List<Employee> emp = sbl.getemployee();
            List<EmployeeViewModel> list = new List<EmployeeViewModel>();
            foreach(Employee e in emp)
            {
                EmployeeViewModel empvmodel = new EmployeeViewModel();
                empvmodel.name = e.Firstname+e.lastname;
                empvmodel.salary = e.salary.ToString("C");
                if (e.salary > 15000)
                {
                    empvmodel.salary_color = "yellow";
                }
                else
                { empvmodel.salary_color = "green"; }
                list.Add(empvmodel);
            }
            elvm.Employees = list;
            elvm.UserName = "Admin";
            return View("MyView",elvm);
        }
    }
}