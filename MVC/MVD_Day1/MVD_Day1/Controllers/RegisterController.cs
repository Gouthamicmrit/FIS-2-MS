using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MVD_Day1.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }

        //getting data thru forms collection
        //using standard html helpers
        [HttpGet]
        public ActionResult CreateRegistration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateRegistration(FormCollection frm)
        {
            string name = frm["txtname"].ToString();
            string pass = frm["txtpass"].ToString();
            string gender = frm["Gender"].ToString();

            bool music = Convert.ToBoolean(frm["M"].Split(',')[0]);
            bool sports = Convert.ToBoolean(frm["S"].Split(',')[0]);
            bool arts = Convert.ToBoolean(frm["A"].Split(',')[0]);

            string Interest = "";
            if (music == true)
                Interest += "Music";
            if (sports == true)
                Interest += "Sports";
            if (arts == true)
                Interest += "Arts";

            string city = frm["City"].ToString();

            StringBuilder sb = new StringBuilder();

            sb.Append(name + "<br/>");
            sb.Append(pass + "<br/>");
            sb.Append(gender + "<br/>");
            sb.Append(city + "<br/>");
            sb.Append(Interest + "<br/>");
            return Content(sb.ToString());
        }

    }
}