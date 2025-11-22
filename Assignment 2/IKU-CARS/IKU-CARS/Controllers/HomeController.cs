using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IKU_CARS.Models;

namespace IKU_CARS.Controllers
{
    public class HomeController : Controller
    {
        private IKUCarDB db;

        public HomeController()
        {
            try
            {
                db = new IKUCarDB();
            }
            catch
            {
                // Database connection failed, continue without it
            }
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Car_List()
        {
            try
            {
                if (db != null)
                {
                    var cars = db.Cars.ToList();
                    return View(cars);
                }
                else
                {
                    return View(new List<Car>());
                }
            }
            catch
            {
                return View(new List<Car>());
            }
        }

        public ActionResult Car_Info(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Car_List");
            }
            
            try
            {
                if (db != null)
                {
                    Car car = db.Cars.Find(id);
                    if (car == null)
                    {
                        return RedirectToAction("Car_List");
                    }
                    return View(car);
                }
                else
                {
                    return RedirectToAction("Car_List");
                }
            }
            catch
            {
                return RedirectToAction("Car_List");
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}