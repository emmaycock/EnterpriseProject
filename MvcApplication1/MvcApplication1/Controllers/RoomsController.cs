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
    public class RoomsController : Controller
    {
        private MvcApplication1Context context = new MvcApplication1Context();

        //
        // GET: /Rooms/

        public ViewResult Index()
        {
            return View(context.Rooms.ToList());
        }

        //
        // GET: /Rooms/Details/5

        public ViewResult Details(int id)
        {
            Room room = context.Rooms.Single(x => x.ID == id);
            return View(room);
        }

        //
        // GET: /Rooms/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Rooms/Create

        [HttpPost]
        public ActionResult Create(Room room)
        {
            if (ModelState.IsValid)
            {
                context.Rooms.Add(room);
                context.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(room);
        }
        
        //
        // GET: /Rooms/Edit/5
 
        public ActionResult Edit(int id)
        {
            Room room = context.Rooms.Single(x => x.ID == id);
            return View(room);
        }

        //
        // POST: /Rooms/Edit/5

        [HttpPost]
        public ActionResult Edit(Room room)
        {
            if (ModelState.IsValid)
            {
                context.Entry(room).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(room);
        }

        //
        // GET: /Rooms/Delete/5
 
        public ActionResult Delete(int id)
        {
            Room room = context.Rooms.Single(x => x.ID == id);
            return View(room);
        }

        //
        // POST: /Rooms/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Room room = context.Rooms.Single(x => x.ID == id);
            context.Rooms.Remove(room);
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