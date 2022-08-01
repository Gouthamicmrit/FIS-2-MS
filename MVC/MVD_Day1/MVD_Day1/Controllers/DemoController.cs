using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVD_Day1.Models;

namespace MVD_Day1.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }

        //action method 1
        public string NormalMethod()
        {
            return "Hello All !!!..";
        }

        //action method 2

        public ContentResult Contents()
        {
            return Content("Good Morning to all of you..");
          //  return Content("<h1>Good Morning to all of You..</h1>");
        }

        //action method 3
        [NonAction]
        public EmptyResult NoResult()
        {
            int amt = 45000;
            float SI = (amt * 3 * 2) / 100;
            return new EmptyResult();
        }

        //action method 4
        public ViewResult ViewResultMethod()
        {
            ViewBag.Data = "This is the View Result of Demo Controller ";
            return View();
        }

        //action method 5

        public JsonResult EmployeeData()
        {
            Employee e = new Employee();
            e.ID = 100;
            e.Name = "Shar Rukh Khan";
            e.Age = 55;
            return Json(e,JsonRequestBehavior.AllowGet);
        }
        //action method redirect 1

        public RedirectResult RedirectMethod()
        {
            return Redirect("Contents");
        }

        //redirect method 2

       public RedirectResult Redirect_To_controller()
        {
            return Redirect("/Home/Contact");
        }

       

    }
}