using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;

namespace NewHotelApp.Models
{
    public class Room
    {
        //Temp Class
        [Column(IsPrimaryKey = true, Storage = "_roomnumberID")]
        public int roomnumberID;

        public int hotelid { get; set; }
        public int doornumber { get; set; }
        public int price { get; set; }
        public String type { get; set; }


    }
}