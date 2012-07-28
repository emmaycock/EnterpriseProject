using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcApplication1.Business_Logic;
using MvcApplication1.Models;

namespace MvcApplication1.Tests
{
    [TestClass]
    public class RateTest1
    {
        private CityHotels_BLL logic = new CityHotels_BLL();
        [TestMethod]
        public void TestShouldCreateRating()
        {
            HotelDetail rating = new HotelDetail();
            rating.cleanliness = 4;
            rating.location = 4;
            rating.room = 4;
            rating.service = 4;
            rating.value = 4;

            decimal overallRating = logic.Rate(rating);

            Assert.IsTrue(overallRating == 4);
        }
        [TestMethod]
        public void TestShouldCalculateAverageRating()
        {
            HotelDetail initialRatings = new HotelDetail();
            initialRatings.numReviews = 2;
            initialRatings.cleanliness = 4;
            initialRatings.location = 4;
            initialRatings.room = 4;
            initialRatings.service = 4;
            initialRatings.value = 4;


            HotelDetail rating = new HotelDetail();
            rating.cleanliness = 1;
            rating.location = 1;
            rating.room = 1;
            rating.service = 1;
            rating.value = 1;
            rating.overallRating = logic.Rate(rating);

            HotelDetail newOverallRating = logic.CalculateAverages(initialRatings, rating);


            Assert.AreEqual(newOverallRating.numReviews, 3);
            Assert.AreEqual(newOverallRating.cleanliness, 3);
            Assert.AreEqual(newOverallRating.location, 3);
           Assert.AreEqual(newOverallRating.room, 3);
            Assert.AreEqual(newOverallRating.service, 3);
            Assert.AreEqual(newOverallRating.value, 3);
            Assert.AreEqual(newOverallRating.overallRating, 3);
        }
    }
}
