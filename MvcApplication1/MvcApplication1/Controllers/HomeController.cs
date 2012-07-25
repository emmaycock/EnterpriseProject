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
        HotelDetailDAL dal = new HotelDetailDAL();
        public ActionResult Index()
        {
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

        public ActionResult LoadCSV()
        {
            // This Action calls import csv from DAL layer

            dal.importCSV();
            return View();
        }
    }
}
