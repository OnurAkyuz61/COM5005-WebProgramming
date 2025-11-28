using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CardRegisteration.Models;

namespace CardRegisteration.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Offer()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Form(Card crd)
        {
            if (ModelState.IsValid)
            {
                ViewBag.name = crd.Name;
                ViewBag.surname = crd.SurName;
                ViewBag.email = crd.Email;
                ViewBag.phone = crd.Phone;
                ViewBag.gender = crd.Gender;
                return View("Result", crd);
            }
            else
            {
                return View();
            }
        }
    }
}

