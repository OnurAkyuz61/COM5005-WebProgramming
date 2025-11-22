using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IKU_CARS.Models;

namespace IKU_CARS.Controllers
{
    public class CarsController : Controller
    {
        private IKUCarDB db = new IKUCarDB();

        // GET: Cars
        public ActionResult Index()
        {
            return View(db.Cars.ToList());
        }

        // GET: Cars/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Car car = db.Cars.Find(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            return View(car);
        }

        // GET: Cars/Create
        public ActionResult Create()
        {
            // Populate CType dropdown
            ViewBag.CTypeList = new SelectList(new List<SelectListItem>
            {
                new SelectListItem { Text = "Sedan", Value = "Sedan" },
                new SelectListItem { Text = "Sport", Value = "Sport" },
                new SelectListItem { Text = "Family", Value = "Family" },
                new SelectListItem { Text = "Van", Value = "Van" }
            }, "Value", "Text");
            
            return View();
        }

        // POST: Cars/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Maker,Model,Year,CType,CImage,Price,CAvailable")] Car car)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // Ensure database context is fresh
                    using (var context = new IKUCarDB())
                    {
                        context.Cars.Add(car);
                        context.SaveChanges();
                    }
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                // Log the error for debugging
                ModelState.AddModelError("", "An error occurred while saving the car: " + ex.Message);
            }

            // Re-populate CType dropdown if validation fails
            ViewBag.CTypeList = new SelectList(new List<SelectListItem>
            {
                new SelectListItem { Text = "Sedan", Value = "Sedan" },
                new SelectListItem { Text = "Sport", Value = "Sport" },
                new SelectListItem { Text = "Family", Value = "Family" },
                new SelectListItem { Text = "Van", Value = "Van" }
            }, "Value", "Text");

            return View(car);
        }

        // GET: Cars/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Car car = db.Cars.Find(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            
            // Populate CType dropdown
            ViewBag.CTypeList = new SelectList(new List<SelectListItem>
            {
                new SelectListItem { Text = "Sedan", Value = "Sedan" },
                new SelectListItem { Text = "Sport", Value = "Sport" },
                new SelectListItem { Text = "Family", Value = "Family" },
                new SelectListItem { Text = "Van", Value = "Van" }
            }, "Value", "Text", car.CType);
            
            return View(car);
        }

        // POST: Cars/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Maker,Model,Year,CType,CImage,Price,CAvailable")] Car car)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // Ensure database context is fresh
                    using (var context = new IKUCarDB())
                    {
                        context.Entry(car).State = EntityState.Modified;
                        context.SaveChanges();
                    }
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                // Log the error for debugging
                ModelState.AddModelError("", "An error occurred while updating the car: " + ex.Message);
            }
            
            // Re-populate CType dropdown if validation fails
            ViewBag.CTypeList = new SelectList(new List<SelectListItem>
            {
                new SelectListItem { Text = "Sedan", Value = "Sedan" },
                new SelectListItem { Text = "Sport", Value = "Sport" },
                new SelectListItem { Text = "Family", Value = "Family" },
                new SelectListItem { Text = "Van", Value = "Van" }
            }, "Value", "Text", car.CType);
            
            return View(car);
        }

        // GET: Cars/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Car car = db.Cars.Find(id);
            if (car == null)
            {
                return HttpNotFound();
            }
            return View(car);
        }

        // POST: Cars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Car car = db.Cars.Find(id);
            db.Cars.Remove(car);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
