using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;

namespace MvcApplication1.Models
{
    public class SearchHotel
    {
        [Column(IsPrimaryKey = true)]
        public int ID { get; set; }

        public String hotelName { get; set; }
        public String city { get; set; }
        public String review { get; set; }

    }
}