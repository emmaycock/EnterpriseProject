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
    public class SearchHotelsController : Controller
    {
        private MvcApplication1Context context = new MvcApplication1Context();

        //
        // GET: /SearchHotels/

        public ViewResult Index()
        {
            return View(context.SearchHotels.ToList());
        }

        //
        // GET: /SearchHotels/Details/5

        public ViewResult Details(int id)
        {
            SearchHotel searchhotel = context.SearchHotels.Single(x => x.ID == id);
            return View(searchhotel);
        }

        //
        // GET: /SearchHotels/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /SearchHotels/Create

        [HttpPost]
        public ActionResult Create(SearchHotel searchhotel)
        {
            if (ModelState.IsValid)
            {
                context.SearchHotels.Add(searchhotel);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(searchhotel);
        }
        
        //
        // GET: /SearchHotels/Edit/5
 
        public ActionResult Edit(int id)
        {
            SearchHotel searchhotel = context.SearchHotels.Single(x => x.ID == id);
            return View(searchhotel);
        }

        //
        // POST: /SearchHotels/Edit/5

        [HttpPost]
        public ActionResult Edit(SearchHotel searchhotel)
        {
            if (ModelState.IsValid)
            {
                context.Entry(searchhotel).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(searchhotel);
        }

        //
        // GET: /SearchHotels/Delete/5
 
        public ActionResult Delete(int id)
        {
            SearchHotel searchhotel = context.SearchHotels.Single(x => x.ID == id);
            return View(searchhotel);
        }

        //
        // POST: /SearchHotels/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            SearchHotel searchhotel = context.SearchHotels.Single(x => x.ID == id);
            context.SearchHotels.Remove(searchhotel);
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