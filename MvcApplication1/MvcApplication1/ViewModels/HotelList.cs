using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcApplication1.ViewModels
{
    public class HotelList
    {
        [Key]
        public int Id { get; set; }
        public string HotelName { get; set; }
        public string HotelCity { get; set; }
        public string HotelImage { get; set; }
        public string HotelDesc { get; set; }
        public string HotelCountry { get; set; }
        public string HotelOverallRating { get; set; }
        
    }
}