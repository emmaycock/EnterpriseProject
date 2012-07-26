using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.ViewModels;
using MvcApplication1.Business_Logic;

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



        public ActionResult SearchHotels(string SearchString)
        {

                    
            
                List<CityHotels_VM> h1 = new List<CityHotels_VM>();
                CityHotels_BLL x1 = new CityHotels_BLL();
                h1 = x1.GetHotelListByCity(SearchString);
                return View("SearchHotels", h1);
            



            
            /*
            if (!String.IsNullOrEmpty(searchCity))
            {
                List<HotelList> h1 = new List<HotelList>();
                Business_Logic.Hotellogic x1 = new Business_Logic.Hotellogic();
                h1 = x1.GetHotelListByCity(searchCity);
                return View("SearchHotels", h1);
            }
            else
            {
                return View("../Home/Index");
            }
            */
        
        
        
        }



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