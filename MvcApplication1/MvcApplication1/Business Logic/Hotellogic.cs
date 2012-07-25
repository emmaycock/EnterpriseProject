using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcApplication1.ViewModels;
using MvcApplication1.Models;

namespace MvcApplication1.Business_Logic
{
    public class Hotellogic
    {
              
        public List<HotelList> GetHotelListByCity(string _city)
        {
                        
            dal.HotelDetailDAL findHotels = new dal.HotelDetailDAL();           

         
            IEnumerable<HotelDetail> returnlist = new List<HotelDetail>();
            //Hotel View Model
            List<HotelList> hotelviewlist = new List<HotelList>();

            //List of hotels matching city entered
            returnlist = findHotels.getHotelByCity(_city);

            foreach (HotelDetail h in returnlist)
            {                         
                                    
                    //Add Hotel to Search Results
                    HotelList searchresults = new HotelList
                    {
                        Id = h.ID,
                        HotelName = h.hotelName,
                        HotelCity = h.city,
                        HotelOverallRating = h.overallRating,
                        HotelCountry = h.country
                    };
                    hotelviewlist.Add(searchresults);                
                
            }

            return hotelviewlist;
        }
          
        
    }
}