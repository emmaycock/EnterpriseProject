using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;


namespace MvcApplication1.Models
{
    //Column names based on data in London csv file in Data folder of project
    [Table(Name = "HOTELDETAIL")]
    public class HotelDetail
    {
        [Column(IsPrimaryKey = true)]
        public int ID { get; set; }
        [Column(Name = "docID")]
        public String docID { get; set; }
        [Column(Name = "HOTELNAME")]
        public String hotelName { get; set; }
        [Column(Name = "HOTELURL")]
        public String hotelUrl { get; set; }
        [Column(Name = "STREET")]
        public String street { get; set; }
        [Column(Name = "CITY")]
        public String city { get; set; }
        [Column(Name = "STATE")]
        public String state { get; set; }
        [Column(Name = "COUNTRY")]
        public String country { get; set; }
        [Column(Name = "ZIP")]
        public String zip { get; set; }
        [Column(Name = "CLASSRATING")]
        public String classRating { get; set; }
        [Column(Name = "PRICE")]
        public String price { get; set; }
        [Column(Name = "NUMREVIEWS")]
        public String numReviews { get; set; }
        [Column(Name = "CLEANLINESS")]
        public String cleanliness { get; set; }
        [Column(Name = "ROOM")]
        public String room { get; set; }
        [Column(Name = "SERVICE")]
        public String service { get; set; }
        [Column(Name = "LOCATION")]
        public String location { get; set; }
        [Column(Name = "VALUE")]
        public String value { get; set; }
        [Column(Name = "COMFORT")]
        public String comfort { get; set; }
        [Column(Name = "OVERALLRATING")]
        public String overallRating { get; set; }


     


    }
}