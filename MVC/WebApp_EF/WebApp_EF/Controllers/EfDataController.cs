using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp_EF.Models;

namespace WebApp_EF.Controllers
{
    public class EfDataController : Controller
    {
        testdbEntities obj = new testdbEntities();
        // GET: EfData
        public ActionResult Index()
        {
            return View(obj.samples.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
    }
}