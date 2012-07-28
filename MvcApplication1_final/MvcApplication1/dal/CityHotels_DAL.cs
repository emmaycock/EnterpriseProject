using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcApplication1.Models;
using System.Configuration;
using MvcApplication1.ingestion;
using MvcApplication1.ViewModels;

//Class for handling Data Access Layer

namespace MvcApplication1.dal
{
    public class CityHotels_DAL
    {
        NewHotelDb db = new NewHotelDb();


        public void importCSV()
        {

            InitialiseCSV csv = new InitialiseCSV();
            List<HotelDetail> data = csv.importHotelCSVData();
            foreach(HotelDetail d in data){
                db.HotelDetails.Add(d);
            }
            db.SaveChanges();

        }


         public IEnumerable<HotelDetail> getHotelByCity(string _city)
             {
                 List<HotelDetail> hotellist = new List<HotelDetail>();
                 IEnumerable<HotelDetail> list = (from h in db.HotelDetails where h.city.Contains(_city) select h);        
                return list;
             }
         

    }

    
}