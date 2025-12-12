using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Ajax_JQuery_Project.Models;

namespace Ajax_JQuery_Project.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Form(Models.StudentModel sm)
        {
            if (ModelState.IsValid)
            {
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append("ID: " + sm.Id + "<br />");
                sb.Append("Name: " + sm.Name + "<br />");
                sb.Append("Addon: " + sm.Addon + "<br />");
                return Content(sb.ToString());
            }
            else
            {
                return View("Index");
            }
        }

        public ActionResult Index2()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Form2(Models.StudentModel sm)
        {
            string value = "ID: " + Convert.ToString(sm.Id)
                         + "<br />Name: " + sm.Name
                         + "<br />Addon: " + Convert.ToString(sm.Addon);

            string s = "$('#output').html('" + value + "');";
            return JavaScript(s);
        }

        public ActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Students(string name)
        {
            var std_List = new List<StudentModel>
            {
                new StudentModel { Id = 1, Name = "Ayse", Addon = false },
                new StudentModel { Id = 2, Name = "Ali", Addon = true },
                new StudentModel { Id = 3, Name = "Can", Addon = false },
            };

            List<StudentModel> std_search = std_List.Where(x => x.Name == name).ToList();

            return Json(std_search, JsonRequestBehavior.AllowGet);
        }
    }
}

