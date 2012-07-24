using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;

namespace MvcApplication1.Models
{
    public class SingleHotel
    {
        [Column(IsPrimaryKey = true)]
        public int ID { get; set; }

        public String HotelName { get; set; }
        public String Street { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public int Zip { get; set; }
        public int Phone { get; set; }
        public String hotelUrl { get; set; }
    }
}