using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.dal;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        CityHotels_DAL dal = new CityHotels_DAL();
        NewHotelDb db = new NewHotelDb();
        public ActionResult Index()
        {


            bool HotelDetailexists = false;

            HotelDetailexists = db.Database.Exists();

            if (HotelDetailexists)
            {

                //for development purposes only
               //db.Database.Delete();
               // db.Database.Create();

            }
            else
            {
                db.Database.Create();


            }
            ViewBag.Message = "";

          
           
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [Authorize]
        public ActionResult LoadCSV()
        {

            var valid_user = "admin";
           if (User.Identity.Name == valid_user)
            {
            // This Action calls import csv from DAL layer

                  dal.importCSV();
             }
            return View();
        }
    }
}
