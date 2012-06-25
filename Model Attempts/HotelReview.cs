using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;

namespace ModelHotel
{
    public class HotelReview
    {
        [Column(IsPrimaryKey = true, Storage = "review_id")]
        public string review_id;

        public String HotelName;
        [Column]
        public String Hotelurl;
        [Column]
        public String Street;
        [Column]
        public String City;
        [Column]
        public String State;
        [Column]
        public int Value;
        [Column]
        public int Comfort;
        [Column]
        public int Overallrating;
        [Column]
    
    }
}
