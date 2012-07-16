using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;

namespace NewHotelApp.Models
{
    public class SearchHotel
    {
        [Column(IsPrimaryKey = true, Storage = "_HotelID")]
        public int HotelID;

        public String hotelName { get; set; }
        public String city { get; set; }
        public String review { get; set; }

    }
}