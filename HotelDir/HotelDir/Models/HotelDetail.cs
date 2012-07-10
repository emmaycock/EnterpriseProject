using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;

namespace HotelDir.Models
{
    //Column names based on data in London csv file in Data folder of project
    [Table(Name = "HOTELDETAILS")]
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


        public HotelDetail()
        {
        }

        //Initialise variables holding imported csv data
        public HotelDetail(String _docID, String _hotelName, String _hotelURL, String _street, String _city, String _state, String _country, String _zip, String _classRating,
            String _price, String _numReviews, String _cleanliness, String _room, String _service, String _location, String _value, String _comfort, String _overallRating)
        {
            this.docID = _docID;
            this.hotelName = _hotelName;
            this.hotelUrl = _hotelURL;
            this.street = _street;
            this.city = _city;
            this.state = _state;
            this.country = _country;
            this.zip = _zip;
            this.classRating = _classRating;
            this.price = _price;
            this.numReviews = _numReviews;
            this.cleanliness = _cleanliness;
            this.room = _room;
            this.service = _service;
            this.location = _location;
            this.value = _value;
            this.comfort = _comfort;
            this.overallRating = _overallRating;
        }



    }
}