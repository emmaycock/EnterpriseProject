using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Models
{
    public class HotelDetailController : Controller
    {
        private NewHotelDb db = new NewHotelDb();

        //
        // GET: /HotelDetail/

        public ActionResult Index()
        {
            return View(db.HotelDetails.ToList());
        }

        //
        // GET: /HotelDetail/Details/5

        public ActionResult Details(int id = 0)
        {
            HotelDetail hoteldetail = db.HotelDetails.Find(id);
            if (hoteldetail == null)
            {
                return HttpNotFound();
            }
            return View(hoteldetail);
        }

        //
        // GET: /HotelDetail/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /HotelDetail/Create

        [HttpPost]
        public ActionResult Create(HotelDetail hoteldetail)
        {
            if (ModelState.IsValid)
            {
                db.HotelDetails.Add(hoteldetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hoteldetail);
        }

        //
        // GET: /HotelDetail/Edit/5

        public ActionResult Edit(int id = 0)
        {
            HotelDetail hoteldetail = db.HotelDetails.Find(id);
            if (hoteldetail == null)
            {
                return HttpNotFound();
            }
            return View(hoteldetail);
        }

        //
        // POST: /HotelDetail/Edit/5

        [HttpPost]
        public ActionResult Edit(HotelDetail hoteldetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hoteldetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hoteldetail);
        }

        //
        // GET: /HotelDetail/Delete/5

        public ActionResult Delete(int id = 0)
        {
            HotelDetail hoteldetail = db.HotelDetails.Find(id);
            if (hoteldetail == null)
            {
                return HttpNotFound();
            }
            return View(hoteldetail);
        }

        //
        // POST: /HotelDetail/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            HotelDetail hoteldetail = db.HotelDetails.Find(id);
            db.HotelDetails.Remove(hoteldetail);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}