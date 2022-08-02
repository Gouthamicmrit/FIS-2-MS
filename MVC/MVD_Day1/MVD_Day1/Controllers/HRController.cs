using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVD_Day1.Models;

namespace MVD_Day1.Controllers
{
    public class HRController : Controller
    {
        // GET: HR
        //calling 
        public ActionResult Index()
        {
            List<Department> deplist = new List<Department>()
            {
                new Department{ID=1, Deptname="IT"},
                new Department{ID=2, Deptname="Accounts"},
                new Department{ID=3, Deptname="HR"},
                new Department{ID=4, Deptname="Admin"},
                
            };

            return View("ListDepartment",deplist);
        }

        public ActionResult ListDepartment(List<Department> dlist)
        {
            //this view will have to receive a list of departments bound to a model 
            //department
            return View(dlist);
        }

        //model binding to a view that returns a collection of employee objects
        public ActionResult ListEmployee()
        {
            List<Employee> emplist = new List<Employee>()
            {
                new Employee{ID=200, Name="Aakash",Age=21},
                new Employee{ID=201, Name="Sakshi",Age=22},
                new Employee{ID=202, Name="Kiran",Age=20},
                new Employee{ID=203, Name="Gouthami",Age=21},
            };

            return View(emplist);
        }

        //model binding to a view that returns one employee object

        public ActionResult DisplayEmployee()
        {
            Employee emp = new Employee()
            {
                ID = 10,
                Name = "Deepak",
                Age = 21
            };

            return View(emp);
        }

        public ActionResult ReceiveTempdata()
        {
            return View();
        }

    }
}