using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{   
    public class SingleHotelsController : Controller
    {
        private MvcApplication1Context context = new MvcApplication1Context();

        //
        // GET: /SingleHotels/

        public ViewResult Index()
        {
            return View(context.SingleHotels.ToList());
        }

        //
        // GET: /SingleHotels/Details/5

        public ViewResult Details(int id)
        {
            SingleHotel singlehotel = context.SingleHotels.Single(x => x.ID == id);
            return View(singlehotel);
        }

        //
        // GET: /SingleHotels/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /SingleHotels/Create

        [HttpPost]
        public ActionResult Create(SingleHotel singlehotel)
        {
            if (ModelState.IsValid)
            {
                context.SingleHotels.Add(singlehotel);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(singlehotel);
        }
        
        //
        // GET: /SingleHotels/Edit/5
 
        public ActionResult Edit(int id)
        {
            SingleHotel singlehotel = context.SingleHotels.Single(x => x.ID == id);
            return View(singlehotel);
        }

        //
        // POST: /SingleHotels/Edit/5

        [HttpPost]
        public ActionResult Edit(SingleHotel singlehotel)
        {
            if (ModelState.IsValid)
            {
                context.Entry(singlehotel).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(singlehotel);
        }

        //
        // GET: /SingleHotels/Delete/5
 
        public ActionResult Delete(int id)
        {
            SingleHotel singlehotel = context.SingleHotels.Single(x => x.ID == id);
            return View(singlehotel);
        }

        //
        // POST: /SingleHotels/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            SingleHotel singlehotel = context.SingleHotels.Single(x => x.ID == id);
            context.SingleHotels.Remove(singlehotel);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) {
                context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}