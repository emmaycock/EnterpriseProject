using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcApplication1.ViewModels;
using MvcApplication1.Models;

namespace MvcApplication1.Business_Logic
{
    public class CityHotels_BLL
    {
              
        public List<CityHotels_VM> GetHotelListByCity(string _city)
        {
                        
            dal.CityHotels_DAL findHotels = new dal.CityHotels_DAL();           

         
            IEnumerable<HotelDetail> returnlist = new List<HotelDetail>();
            //Hotel View Model
            List<CityHotels_VM> hotelviewlist = new List<CityHotels_VM>();

            //List of hotels matching city entered
            returnlist = findHotels.getHotelByCity(_city);

            foreach (HotelDetail h in returnlist)
            {                         
                                    
                    //Add Hotel to Search Results
                    CityHotels_VM searchresults = new CityHotels_VM
                    {
                        Id = h.ID,
                        HotelName = h.hotelName,
                        HotelCity = h.city,
                        HotelCountry = h.country,
                        HotelOverallRating = h.overallRating
                    };
                    hotelviewlist.Add(searchresults);                
                
            }

            return hotelviewlist;
        }


        public decimal Rate(HotelDetail rating)
        {
            decimal overallRating = 0;
            overallRating = (rating.cleanliness + rating.location + rating.room + rating.service + rating.value) / 5;
            return overallRating;
        }

        public HotelDetail CalculateAverages(HotelDetail initialRatings, HotelDetail rating)
        {



            var initial_num_reviews = initialRatings.numReviews;
            initialRatings.numReviews += 1;

            initialRatings.cleanliness = (((initialRatings.cleanliness) * initial_num_reviews) +
                rating.cleanliness) / initialRatings.numReviews;
            initialRatings.location = (((initialRatings.location) * initial_num_reviews) +
                rating.location) / initialRatings.numReviews;
            initialRatings.room = (((initialRatings.room) * initial_num_reviews) +
                rating.room) / initialRatings.numReviews;
            initialRatings.service = (((initialRatings.service) * initial_num_reviews) +
                rating.service) / initialRatings.numReviews;
            initialRatings.value = (((initialRatings.value) * initial_num_reviews) +
                rating.value) / initialRatings.numReviews;
            initialRatings.overallRating = Rate(initialRatings);
          
            return initialRatings;
        }
    }
}