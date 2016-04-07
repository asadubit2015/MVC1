using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> getemployee()
        {
            List<Employee> employee = new List<Employee>();
            Employee emp = new Employee();
            emp.Firstname = "Asad";
            emp.lastname = "Hussain";
            emp.salary = 25000;
            employee.Add(emp);
            return employee;
        }
    }
}