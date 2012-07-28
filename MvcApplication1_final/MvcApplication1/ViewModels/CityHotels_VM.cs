using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcApplication1.ViewModels
{
    public class CityHotels_VM
    {
        [Key]
        public int Id { get; set; }
        public string HotelName { get; set; }
        public string HotelCity { get; set; }
        public string HotelCountry { get; set; }
        public decimal HotelOverallRating { get; set; }
        
    }
}