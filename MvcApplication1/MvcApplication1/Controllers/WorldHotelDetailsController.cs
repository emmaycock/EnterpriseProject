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
    public class WorldHotelDetailsController : Controller
    {
        private MvcApplication1Context context = new MvcApplication1Context();

        //
        // GET: /WorldHotelDetails/

        public ViewResult Index()
        {
            return View(context.WorldHotelDetails.ToList());
        }

        //
        // GET: /WorldHotelDetails/Details/5

        public ViewResult Details(int id)
        {
            WorldHotelDetail worldhoteldetail = context.WorldHotelDetails.Single(x => x.ID == id);
            return View(worldhoteldetail);
        }

        //
        // GET: /WorldHotelDetails/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /WorldHotelDetails/Create

        [HttpPost]
        public ActionResult Create(WorldHotelDetail worldhoteldetail)
        {
            if (ModelState.IsValid)
            {
                context.WorldHotelDetails.Add(worldhoteldetail);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(worldhoteldetail);
        }
        
        //
        // GET: /WorldHotelDetails/Edit/5
 
        public ActionResult Edit(int id)
        {
            WorldHotelDetail worldhoteldetail = context.WorldHotelDetails.Single(x => x.ID == id);
            return View(worldhoteldetail);
        }

        //
        // POST: /WorldHotelDetails/Edit/5

        [HttpPost]
        public ActionResult Edit(WorldHotelDetail worldhoteldetail)
        {
            if (ModelState.IsValid)
            {
                context.Entry(worldhoteldetail).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(worldhoteldetail);
        }

        //
        // GET: /WorldHotelDetails/Delete/5
 
        public ActionResult Delete(int id)
        {
            WorldHotelDetail worldhoteldetail = context.WorldHotelDetails.Single(x => x.ID == id);
            return View(worldhoteldetail);
        }

        //
        // POST: /WorldHotelDetails/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            WorldHotelDetail worldhoteldetail = context.WorldHotelDetails.Single(x => x.ID == id);
            context.WorldHotelDetails.Remove(worldhoteldetail);
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