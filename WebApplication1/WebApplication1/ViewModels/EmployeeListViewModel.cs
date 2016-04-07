using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;
using WebApplication1.ViewModels;

namespace WebApplication1.ViewModels
{
    public class EmployeeListViewModel
{
         public string UserName { get; set; }
    public List<EmployeeViewModel> Employees { get; set; }
}
}