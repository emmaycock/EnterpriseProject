using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;

namespace ModelHotel
{
    public class NewYork
    {

        [Column(IsPrimaryKey = true, Storage = "_docID")]
        public int docID;

        public String HotelName { get; set; }
        public String Hotelurl { get; set; }
        public String Street { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public String Country { get; set; }
        public int Zip { get; set; }
        public int Class { get; set; }
        public int Price { get; set; }
        public int Numreviews { get; set; }
        public int Cleanliness { get; set; }
        public int Room { get; set; }
        public int Service { get; set; }
        public int Location { get; set; }
        public int Value { get; set; }
        public int Comfort { get; set; }
        public int Overallrating { get; set; }

    }
}