using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;

namespace MvcApplication1.Models
{

    //Column names based on data in Worldwide Sletoh csv file in Data folder of project
    [Table(Name = "WORLDHOTELDETAIL")]
    public class WorldHotelDetail
    {
        [Column(IsPrimaryKey = true)]
        public int ID { get; set; }
        [Column(Name = "WORLDHOTELID")]
        public String worldhotelID { get; set; }
        [Column(Name = "HOTELNAME")]
        public String hotelName { get; set; }
        [Column(Name = "STREET")]
        public String street { get; set; }
        [Column(Name = "ZIP")]
        public String zip { get; set; }
        [Column(Name = "CITY")]
        public String city { get; set; }
        [Column(Name = "STATE")]
        public String state { get; set; }
        [Column(Name = "COUNTRY")]
        public String country { get; set; }
        [Column(Name = "LATITUDE")]
        public String latitude { get; set; }
        [Column(Name = "LONGITUDE")]
        public String longitude { get; set; }
        [Column(Name = "HOTELURL")]
        public String hotelUrl { get; set; }
        [Column(Name = "STARRATING")]
        public String starRating { get; set; }
        [Column(Name = "THUMBNAILURL")]
        public String thumbnailurl { get; set; }
        [Column(Name = "PHOTOURL")]
        public String photourl { get; set; }
        [Column(Name = "DESCRIPTION")]
        public String description { get; set; }


    }
}